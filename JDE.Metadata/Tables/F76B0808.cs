using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0808 - .
/// </summary>
public class F76B0808 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STB76ATCT.
        /// </summary>
        public const string STB76ATCT = "STB76ATCT";

        /// <summary>
        /// STJOBS.
        /// </summary>
        public const string STJOBS = "STJOBS";

        /// <summary>
        /// STB76BLCK.
        /// </summary>
        public const string STB76BLCK = "STB76BLCK";

        /// <summary>
        /// STBRAUFE.
        /// </summary>
        public const string STBRAUFE = "STBRAUFE";

        /// <summary>
        /// STB76URAB.
        /// </summary>
        public const string STB76URAB = "STB76URAB";

        /// <summary>
        /// STB76URAT.
        /// </summary>
        public const string STB76URAT = "STB76URAT";

        /// <summary>
        /// STB76URRF.
        /// </summary>
        public const string STB76URRF = "STB76URRF";

        /// <summary>
        /// STB76URDT.
        /// </summary>
        public const string STB76URDT = "STB76URDT";

        /// <summary>
        /// STB76URCD.
        /// </summary>
        public const string STB76URCD = "STB76URCD";

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
    public override string TableName => "F76B0808";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STB76ATCT", "STB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("STJOBS", "STJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("STB76BLCK", "STB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("STBRAUFE", "STBRAUFE", JdeDataType.String, 6, true, true),
        new JdeField("STB76URAB", "STB76URAB", JdeDataType.Numeric),
        new JdeField("STB76URAT", "STB76URAT", JdeDataType.Numeric),
        new JdeField("STB76URRF", "STB76URRF", JdeDataType.String, 30),
        new JdeField("STB76URDT", "STB76URDT", JdeDataType.Numeric),
        new JdeField("STB76URCD", "STB76URCD", JdeDataType.String, 4),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0808_0", "Primary Key on STB76ATCT, STJOBS, STB76BLCK, STBRAUFE", new[] { "STB76ATCT", "STJOBS", "STB76BLCK", "STBRAUFE" }, isUnique: true, isPrimaryKey: true)
    };
}
