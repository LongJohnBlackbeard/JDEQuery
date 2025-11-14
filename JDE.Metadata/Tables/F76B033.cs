using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B033 - .
/// </summary>
public class F76B033 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDB76IDOC.
        /// </summary>
        public const string IDB76IDOC = "IDB76IDOC";

        /// <summary>
        /// IDB76IDCT.
        /// </summary>
        public const string IDB76IDCT = "IDB76IDCT";

        /// <summary>
        /// IDB76NCRD.
        /// </summary>
        public const string IDB76NCRD = "IDB76NCRD";

        /// <summary>
        /// IDB76URAB.
        /// </summary>
        public const string IDB76URAB = "IDB76URAB";

        /// <summary>
        /// IDB76URAT.
        /// </summary>
        public const string IDB76URAT = "IDB76URAT";

        /// <summary>
        /// IDB76URRF.
        /// </summary>
        public const string IDB76URRF = "IDB76URRF";

        /// <summary>
        /// IDB76URDT.
        /// </summary>
        public const string IDB76URDT = "IDB76URDT";

        /// <summary>
        /// IDB76URCD.
        /// </summary>
        public const string IDB76URCD = "IDB76URCD";

        /// <summary>
        /// IDUSER.
        /// </summary>
        public const string IDUSER = "IDUSER";

        /// <summary>
        /// IDPID.
        /// </summary>
        public const string IDPID = "IDPID";

        /// <summary>
        /// IDJOBN.
        /// </summary>
        public const string IDJOBN = "IDJOBN";

        /// <summary>
        /// IDUPMJ.
        /// </summary>
        public const string IDUPMJ = "IDUPMJ";

        /// <summary>
        /// IDUPMT.
        /// </summary>
        public const string IDUPMT = "IDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B033";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDB76IDOC", "IDB76IDOC", JdeDataType.String, 20, true, true),
        new JdeField("IDB76IDCT", "IDB76IDCT", JdeDataType.String, 6, true, true),
        new JdeField("IDB76NCRD", "IDB76NCRD", JdeDataType.String, 40),
        new JdeField("IDB76URAB", "IDB76URAB", JdeDataType.Numeric),
        new JdeField("IDB76URAT", "IDB76URAT", JdeDataType.Numeric),
        new JdeField("IDB76URRF", "IDB76URRF", JdeDataType.String, 30),
        new JdeField("IDB76URDT", "IDB76URDT", JdeDataType.Numeric),
        new JdeField("IDB76URCD", "IDB76URCD", JdeDataType.String, 4),
        new JdeField("IDUSER", "IDUSER", JdeDataType.String, 20),
        new JdeField("IDPID", "IDPID", JdeDataType.String, 20),
        new JdeField("IDJOBN", "IDJOBN", JdeDataType.String, 20),
        new JdeField("IDUPMJ", "IDUPMJ", JdeDataType.Numeric),
        new JdeField("IDUPMT", "IDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B033_0", "Primary Key on IDB76IDOC, IDB76IDCT", new[] { "IDB76IDOC", "IDB76IDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
