using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9022 - .
/// </summary>
public class F74R9022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGR74REPN.
        /// </summary>
        public const string AGR74REPN = "AGR74REPN";

        /// <summary>
        /// AGR74RROW.
        /// </summary>
        public const string AGR74RROW = "AGR74RROW";

        /// <summary>
        /// AGR74CODT.
        /// </summary>
        public const string AGR74CODT = "AGR74CODT";

        /// <summary>
        /// AGR74RCOL.
        /// </summary>
        public const string AGR74RCOL = "AGR74RCOL";

        /// <summary>
        /// AGLNID.
        /// </summary>
        public const string AGLNID = "AGLNID";

        /// <summary>
        /// AGANI.
        /// </summary>
        public const string AGANI = "AGANI";

        /// <summary>
        /// AGR74ANI1.
        /// </summary>
        public const string AGR74ANI1 = "AGR74ANI1";

        /// <summary>
        /// AGFROM.
        /// </summary>
        public const string AGFROM = "AGFROM";

        /// <summary>
        /// AGTHRU.
        /// </summary>
        public const string AGTHRU = "AGTHRU";

        /// <summary>
        /// AGOBJF.
        /// </summary>
        public const string AGOBJF = "AGOBJF";

        /// <summary>
        /// AGOBJT.
        /// </summary>
        public const string AGOBJT = "AGOBJT";

        /// <summary>
        /// AGFSUB.
        /// </summary>
        public const string AGFSUB = "AGFSUB";

        /// <summary>
        /// AGSUBT.
        /// </summary>
        public const string AGSUBT = "AGSUBT";

        /// <summary>
        /// AGR74CAFR.
        /// </summary>
        public const string AGR74CAFR = "AGR74CAFR";

        /// <summary>
        /// AGR74CATH.
        /// </summary>
        public const string AGR74CATH = "AGR74CATH";

        /// <summary>
        /// AGR74FORM.
        /// </summary>
        public const string AGR74FORM = "AGR74FORM";

        /// <summary>
        /// AGURAB.
        /// </summary>
        public const string AGURAB = "AGURAB";

        /// <summary>
        /// AGURAT.
        /// </summary>
        public const string AGURAT = "AGURAT";

        /// <summary>
        /// AGURDT.
        /// </summary>
        public const string AGURDT = "AGURDT";

        /// <summary>
        /// AGURRF.
        /// </summary>
        public const string AGURRF = "AGURRF";

        /// <summary>
        /// AGUSER.
        /// </summary>
        public const string AGUSER = "AGUSER";

        /// <summary>
        /// AGPID.
        /// </summary>
        public const string AGPID = "AGPID";

        /// <summary>
        /// AGJOBN.
        /// </summary>
        public const string AGJOBN = "AGJOBN";

        /// <summary>
        /// AGUPMJ.
        /// </summary>
        public const string AGUPMJ = "AGUPMJ";

        /// <summary>
        /// AGUPMT.
        /// </summary>
        public const string AGUPMT = "AGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGR74REPN", "AGR74REPN", JdeDataType.String, 40, true, true),
        new JdeField("AGR74RROW", "AGR74RROW", JdeDataType.String, 8, true, true),
        new JdeField("AGR74CODT", "AGR74CODT", JdeDataType.String, 6),
        new JdeField("AGR74RCOL", "AGR74RCOL", JdeDataType.String, 8, true, true),
        new JdeField("AGLNID", "AGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AGANI", "AGANI", JdeDataType.String, 58),
        new JdeField("AGR74ANI1", "AGR74ANI1", JdeDataType.String, 58),
        new JdeField("AGFROM", "AGFROM", JdeDataType.String, 30),
        new JdeField("AGTHRU", "AGTHRU", JdeDataType.String, 30),
        new JdeField("AGOBJF", "AGOBJF", JdeDataType.String, 12),
        new JdeField("AGOBJT", "AGOBJT", JdeDataType.String, 12),
        new JdeField("AGFSUB", "AGFSUB", JdeDataType.String, 16),
        new JdeField("AGSUBT", "AGSUBT", JdeDataType.String, 16),
        new JdeField("AGR74CAFR", "AGR74CAFR", JdeDataType.String, 20),
        new JdeField("AGR74CATH", "AGR74CATH", JdeDataType.String, 20),
        new JdeField("AGR74FORM", "AGR74FORM", JdeDataType.String, 360),
        new JdeField("AGURAB", "AGURAB", JdeDataType.Numeric),
        new JdeField("AGURAT", "AGURAT", JdeDataType.Numeric),
        new JdeField("AGURDT", "AGURDT", JdeDataType.Numeric),
        new JdeField("AGURRF", "AGURRF", JdeDataType.String, 30),
        new JdeField("AGUSER", "AGUSER", JdeDataType.String, 20),
        new JdeField("AGPID", "AGPID", JdeDataType.String, 20),
        new JdeField("AGJOBN", "AGJOBN", JdeDataType.String, 20),
        new JdeField("AGUPMJ", "AGUPMJ", JdeDataType.Numeric),
        new JdeField("AGUPMT", "AGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9022_0", "Primary Key on AGR74REPN, AGR74RROW, AGR74RCOL, AGLNID", new[] { "AGR74REPN", "AGR74RROW", "AGR74RCOL", "AGLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
