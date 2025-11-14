using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52131 - .
/// </summary>
public class F52131 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GRRACD.
        /// </summary>
        public const string GRRACD = "GRRACD";

        /// <summary>
        /// GRDL01.
        /// </summary>
        public const string GRDL01 = "GRDL01";

        /// <summary>
        /// GRDTFR.
        /// </summary>
        public const string GRDTFR = "GRDTFR";

        /// <summary>
        /// GRDTTO.
        /// </summary>
        public const string GRDTTO = "GRDTTO";

        /// <summary>
        /// GRMKRP.
        /// </summary>
        public const string GRMKRP = "GRMKRP";

        /// <summary>
        /// GRLNID.
        /// </summary>
        public const string GRLNID = "GRLNID";

        /// <summary>
        /// GRPID.
        /// </summary>
        public const string GRPID = "GRPID";

        /// <summary>
        /// GRUSER.
        /// </summary>
        public const string GRUSER = "GRUSER";

        /// <summary>
        /// GRJOBN.
        /// </summary>
        public const string GRJOBN = "GRJOBN";

        /// <summary>
        /// GRUPMJ.
        /// </summary>
        public const string GRUPMJ = "GRUPMJ";

        /// <summary>
        /// GRUPMT.
        /// </summary>
        public const string GRUPMT = "GRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52131";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GRRACD", "GRRACD", JdeDataType.String, 6, true, true),
        new JdeField("GRDL01", "GRDL01", JdeDataType.String, 60),
        new JdeField("GRDTFR", "GRDTFR", JdeDataType.Numeric),
        new JdeField("GRDTTO", "GRDTTO", JdeDataType.Numeric),
        new JdeField("GRMKRP", "GRMKRP", JdeDataType.Numeric),
        new JdeField("GRLNID", "GRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("GRPID", "GRPID", JdeDataType.String, 20),
        new JdeField("GRUSER", "GRUSER", JdeDataType.String, 20),
        new JdeField("GRJOBN", "GRJOBN", JdeDataType.String, 20),
        new JdeField("GRUPMJ", "GRUPMJ", JdeDataType.Numeric),
        new JdeField("GRUPMT", "GRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52131_0", "Primary Key on GRRACD, GRLNID", new[] { "GRRACD", "GRLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52131_2", "Index on GRRACD, GRDTFR", new[] { "GRRACD", "GRDTFR" }),
        new JdeIndex("F52131_3", "Index on GRRACD", new[] { "GRRACD" })
    };
}
