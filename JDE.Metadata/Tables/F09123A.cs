using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09123A - .
/// </summary>
public class F09123A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BOOVERRDE.
        /// </summary>
        public const string BOOVERRDE = "BOOVERRDE";

        /// <summary>
        /// BODL01.
        /// </summary>
        public const string BODL01 = "BODL01";

        /// <summary>
        /// BOBASR.
        /// </summary>
        public const string BOBASR = "BOBASR";

        /// <summary>
        /// BOBAVL.
        /// </summary>
        public const string BOBAVL = "BOBAVL";

        /// <summary>
        /// BOMCU.
        /// </summary>
        public const string BOMCU = "BOMCU";

        /// <summary>
        /// BOPID.
        /// </summary>
        public const string BOPID = "BOPID";

        /// <summary>
        /// BOUSER.
        /// </summary>
        public const string BOUSER = "BOUSER";

        /// <summary>
        /// BOJOBN.
        /// </summary>
        public const string BOJOBN = "BOJOBN";

        /// <summary>
        /// BOUPMJ.
        /// </summary>
        public const string BOUPMJ = "BOUPMJ";

        /// <summary>
        /// BOUPMT.
        /// </summary>
        public const string BOUPMT = "BOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09123A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BOOVERRDE", "BOOVERRDE", JdeDataType.String, 10, true, true),
        new JdeField("BODL01", "BODL01", JdeDataType.String, 60),
        new JdeField("BOBASR", "BOBASR", JdeDataType.String, 4, true, true),
        new JdeField("BOBAVL", "BOBAVL", JdeDataType.String, 24, true, true),
        new JdeField("BOMCU", "BOMCU", JdeDataType.String, 24),
        new JdeField("BOPID", "BOPID", JdeDataType.String, 20),
        new JdeField("BOUSER", "BOUSER", JdeDataType.String, 20),
        new JdeField("BOJOBN", "BOJOBN", JdeDataType.String, 20),
        new JdeField("BOUPMJ", "BOUPMJ", JdeDataType.Numeric),
        new JdeField("BOUPMT", "BOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09123A_0", "Primary Key on BOOVERRDE, BOBASR, BOBAVL", new[] { "BOOVERRDE", "BOBASR", "BOBAVL" }, isUnique: true, isPrimaryKey: true)
    };
}
