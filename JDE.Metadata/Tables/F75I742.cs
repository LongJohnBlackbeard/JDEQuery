using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I742 - .
/// </summary>
public class F75I742 : JdeTable
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
        /// STSFXE.
        /// </summary>
        public const string STSFXE = "STSFXE";

        /// <summary>
        /// STLNID.
        /// </summary>
        public const string STLNID = "STLNID";

        /// <summary>
        /// STPYID.
        /// </summary>
        public const string STPYID = "STPYID";

        /// <summary>
        /// STRC5.
        /// </summary>
        public const string STRC5 = "STRC5";

        /// <summary>
        /// STI75TCOC.
        /// </summary>
        public const string STI75TCOC = "STI75TCOC";

        /// <summary>
        /// STTRDJ.
        /// </summary>
        public const string STTRDJ = "STTRDJ";

        /// <summary>
        /// STBCRC.
        /// </summary>
        public const string STBCRC = "STBCRC";

        /// <summary>
        /// STAA.
        /// </summary>
        public const string STAA = "STAA";

        /// <summary>
        /// STICUT.
        /// </summary>
        public const string STICUT = "STICUT";

        /// <summary>
        /// STICU.
        /// </summary>
        public const string STICU = "STICU";

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
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I742";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STDOC", "STDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("STDCT", "STDCT", JdeDataType.String, 4, true, true),
        new JdeField("STKCO", "STKCO", JdeDataType.String, 10, true, true),
        new JdeField("STSFX", "STSFX", JdeDataType.String, 6, true, true),
        new JdeField("STSFXE", "STSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("STLNID", "STLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("STPYID", "STPYID", JdeDataType.Numeric),
        new JdeField("STRC5", "STRC5", JdeDataType.Numeric),
        new JdeField("STI75TCOC", "STI75TCOC", JdeDataType.String, 2),
        new JdeField("STTRDJ", "STTRDJ", JdeDataType.Numeric),
        new JdeField("STBCRC", "STBCRC", JdeDataType.String, 6),
        new JdeField("STAA", "STAA", JdeDataType.Numeric),
        new JdeField("STICUT", "STICUT", JdeDataType.String, 4),
        new JdeField("STICU", "STICU", JdeDataType.Numeric),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I742_0", "Primary Key on STDOC, STDCT, STKCO, STSFX, STSFXE, STLNID", new[] { "STDOC", "STDCT", "STKCO", "STSFX", "STSFXE", "STLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
