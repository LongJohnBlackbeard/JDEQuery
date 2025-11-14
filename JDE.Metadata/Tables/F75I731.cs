using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I731 - .
/// </summary>
public class F75I731 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STDOC.
        /// </summary>
        public const string STDOC = "STDOC";

        /// <summary>
        /// STDCT.
        /// </summary>
        public const string STDCT = "STDCT";

        /// <summary>
        /// STKCO.
        /// </summary>
        public const string STKCO = "STKCO";

        /// <summary>
        /// STSFX.
        /// </summary>
        public const string STSFX = "STSFX";

        /// <summary>
        /// STAST.
        /// </summary>
        public const string STAST = "STAST";

        /// <summary>
        /// STGLC.
        /// </summary>
        public const string STGLC = "STGLC";

        /// <summary>
        /// STDOCO.
        /// </summary>
        public const string STDOCO = "STDOCO";

        /// <summary>
        /// STDCTO.
        /// </summary>
        public const string STDCTO = "STDCTO";

        /// <summary>
        /// STKCOO.
        /// </summary>
        public const string STKCOO = "STKCOO";

        /// <summary>
        /// STLNID.
        /// </summary>
        public const string STLNID = "STLNID";

        /// <summary>
        /// STI75TXRG.
        /// </summary>
        public const string STI75TXRG = "STI75TXRG";

        /// <summary>
        /// STI75TXTY.
        /// </summary>
        public const string STI75TXTY = "STI75TXTY";

        /// <summary>
        /// STI75SRCT.
        /// </summary>
        public const string STI75SRCT = "STI75SRCT";

        /// <summary>
        /// STMCU.
        /// </summary>
        public const string STMCU = "STMCU";

        /// <summary>
        /// STI75LNTY.
        /// </summary>
        public const string STI75LNTY = "STI75LNTY";

        /// <summary>
        /// STI75RECU.
        /// </summary>
        public const string STI75RECU = "STI75RECU";

        /// <summary>
        /// STI75RCLA.
        /// </summary>
        public const string STI75RCLA = "STI75RCLA";

        /// <summary>
        /// STACNT.
        /// </summary>
        public const string STACNT = "STACNT";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STTDAY.
        /// </summary>
        public const string STTDAY = "STTDAY";

        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STDL01.
        /// </summary>
        public const string STDL01 = "STDL01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I731";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STDOC", "STDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("STDCT", "STDCT", JdeDataType.String, 4, true, true),
        new JdeField("STKCO", "STKCO", JdeDataType.String, 10, true, true),
        new JdeField("STSFX", "STSFX", JdeDataType.String, 6, true, true),
        new JdeField("STAST", "STAST", JdeDataType.String, 16),
        new JdeField("STGLC", "STGLC", JdeDataType.String, 8),
        new JdeField("STDOCO", "STDOCO", JdeDataType.Numeric),
        new JdeField("STDCTO", "STDCTO", JdeDataType.String, 4),
        new JdeField("STKCOO", "STKCOO", JdeDataType.String, 10),
        new JdeField("STLNID", "STLNID", JdeDataType.Numeric),
        new JdeField("STI75TXRG", "STI75TXRG", JdeDataType.String, 10),
        new JdeField("STI75TXTY", "STI75TXTY", JdeDataType.String, 10),
        new JdeField("STI75SRCT", "STI75SRCT", JdeDataType.String, 12),
        new JdeField("STMCU", "STMCU", JdeDataType.String, 24),
        new JdeField("STI75LNTY", "STI75LNTY", JdeDataType.String, 4),
        new JdeField("STI75RECU", "STI75RECU", JdeDataType.String, 2),
        new JdeField("STI75RCLA", "STI75RCLA", JdeDataType.String, 2),
        new JdeField("STACNT", "STACNT", JdeDataType.String, 2),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STTDAY", "STTDAY", JdeDataType.Numeric),
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric),
        new JdeField("STDL01", "STDL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I731_0", "Primary Key on STDOC, STDCT, STKCO, STSFX", new[] { "STDOC", "STDCT", "STKCO", "STSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I731_2", "Index on STDOCO, STDCTO, STKCOO, STLNID", new[] { "STDOCO", "STDCTO", "STKCOO", "STLNID" })
    };
}
