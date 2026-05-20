-- ============================================================
-- Migration: Buat tabel TM_AuditLog
-- Jalankan di SQL Server sebelum deploy
-- ============================================================

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'TM_AuditLog')
BEGIN
    CREATE TABLE [dbo].[TM_AuditLog] (
        [Id]             BIGINT IDENTITY(1,1) NOT NULL,
        [TableName]      NVARCHAR(100)        NOT NULL,
        [Action]         NVARCHAR(20)         NOT NULL,
        [PrimaryKey]     NVARCHAR(200)        NULL,
        [OldValues]      NVARCHAR(MAX)        NULL,
        [NewValues]      NVARCHAR(MAX)        NULL,
        [ChangedColumns] NVARCHAR(MAX)        NULL,
        [ChangedBy]      NVARCHAR(100)        NOT NULL,
        [ChangedAt]      DATETIME             NOT NULL DEFAULT GETDATE(),
        [SiteCode]       NVARCHAR(50)         NULL,
        CONSTRAINT [PK_TM_AuditLog] PRIMARY KEY CLUSTERED ([Id] ASC)
    );

    -- Index untuk query audit by table/key
    CREATE INDEX [IX_AuditLog_TableName] ON [dbo].[TM_AuditLog] ([TableName], [ChangedAt] DESC);
    CREATE INDEX [IX_AuditLog_ChangedBy] ON [dbo].[TM_AuditLog] ([ChangedBy], [ChangedAt] DESC);

    PRINT 'Table TM_AuditLog berhasil dibuat.';
END
ELSE
    PRINT 'Table TM_AuditLog sudah ada, skip.';
