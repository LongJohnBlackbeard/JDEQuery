using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A48 - .
/// </summary>
public class F76A48 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIPYID.
        /// </summary>
        public const string PIPYID = "PIPYID";

        /// <summary>
        /// PIEV01.
        /// </summary>
        public const string PIEV01 = "PIEV01";

        /// <summary>
        /// PIMATH01.
        /// </summary>
        public const string PIMATH01 = "PIMATH01";

        /// <summary>
        /// PIURC1.
        /// </summary>
        public const string PIURC1 = "PIURC1";

        /// <summary>
        /// PIURDT.
        /// </summary>
        public const string PIURDT = "PIURDT";

        /// <summary>
        /// PIURAT.
        /// </summary>
        public const string PIURAT = "PIURAT";

        /// <summary>
        /// PIURAB.
        /// </summary>
        public const string PIURAB = "PIURAB";

        /// <summary>
        /// PIURRF.
        /// </summary>
        public const string PIURRF = "PIURRF";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIUPMT.
        /// </summary>
        public const string PIUPMT = "PIUPMT";

        /// <summary>
        /// PIEFTJ.
        /// </summary>
        public const string PIEFTJ = "PIEFTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76A48";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIPYID", "PIPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("PIEV01", "PIEV01", JdeDataType.String, 2, true, true),
        new JdeField("PIMATH01", "PIMATH01", JdeDataType.Numeric),
        new JdeField("PIURC1", "PIURC1", JdeDataType.String, 6),
        new JdeField("PIURDT", "PIURDT", JdeDataType.Numeric),
        new JdeField("PIURAT", "PIURAT", JdeDataType.Numeric),
        new JdeField("PIURAB", "PIURAB", JdeDataType.Numeric),
        new JdeField("PIURRF", "PIURRF", JdeDataType.String, 30),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIUPMT", "PIUPMT", JdeDataType.Numeric),
        new JdeField("PIEFTJ", "PIEFTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A48_0", "Primary Key on PIPYID, PIEV01", new[] { "PIPYID", "PIEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
