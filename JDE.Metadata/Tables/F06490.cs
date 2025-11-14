using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06490 - .
/// </summary>
public class F06490 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JRPRID.
        /// </summary>
        public const string JRPRID = "JRPRID";

        /// <summary>
        /// JRICU.
        /// </summary>
        public const string JRICU = "JRICU";

        /// <summary>
        /// JRANN8.
        /// </summary>
        public const string JRANN8 = "JRANN8";

        /// <summary>
        /// JRAPTF.
        /// </summary>
        public const string JRAPTF = "JRAPTF";

        /// <summary>
        /// JRCTL2.
        /// </summary>
        public const string JRCTL2 = "JRCTL2";

        /// <summary>
        /// JRANI.
        /// </summary>
        public const string JRANI = "JRANI";

        /// <summary>
        /// JRHMCO.
        /// </summary>
        public const string JRHMCO = "JRHMCO";

        /// <summary>
        /// JRHMCU.
        /// </summary>
        public const string JRHMCU = "JRHMCU";

        /// <summary>
        /// JRCKD.
        /// </summary>
        public const string JRCKD = "JRCKD";

        /// <summary>
        /// JRAN8.
        /// </summary>
        public const string JRAN8 = "JRAN8";

        /// <summary>
        /// JRPDBA.
        /// </summary>
        public const string JRPDBA = "JRPDBA";

        /// <summary>
        /// JRTARA.
        /// </summary>
        public const string JRTARA = "JRTARA";

        /// <summary>
        /// JRPTAX.
        /// </summary>
        public const string JRPTAX = "JRPTAX";

        /// <summary>
        /// JRUN.
        /// </summary>
        public const string JRUN = "JRUN";

        /// <summary>
        /// JRWANO.
        /// </summary>
        public const string JRWANO = "JRWANO";

        /// <summary>
        /// JRDEDM.
        /// </summary>
        public const string JRDEDM = "JRDEDM";

        /// <summary>
        /// JRGPA.
        /// </summary>
        public const string JRGPA = "JRGPA";

        /// <summary>
        /// JRCO.
        /// </summary>
        public const string JRCO = "JRCO";

        /// <summary>
        /// JRMCU.
        /// </summary>
        public const string JRMCU = "JRMCU";

        /// <summary>
        /// JROBJ.
        /// </summary>
        public const string JROBJ = "JROBJ";

        /// <summary>
        /// JRSUB.
        /// </summary>
        public const string JRSUB = "JRSUB";

        /// <summary>
        /// JRSBL.
        /// </summary>
        public const string JRSBL = "JRSBL";

        /// <summary>
        /// JRSBLT.
        /// </summary>
        public const string JRSBLT = "JRSBLT";
    }

    /// <inheritdoc />
    public override string TableName => "F06490";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JRPRID", "JRPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("JRICU", "JRICU", JdeDataType.Numeric, null, true, true),
        new JdeField("JRANN8", "JRANN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JRAPTF", "JRAPTF", JdeDataType.String, 2, true, true),
        new JdeField("JRCTL2", "JRCTL2", JdeDataType.String, 62, true, true),
        new JdeField("JRANI", "JRANI", JdeDataType.String, 58, true, true),
        new JdeField("JRHMCO", "JRHMCO", JdeDataType.String, 10),
        new JdeField("JRHMCU", "JRHMCU", JdeDataType.String, 24),
        new JdeField("JRCKD", "JRCKD", JdeDataType.Numeric),
        new JdeField("JRAN8", "JRAN8", JdeDataType.Numeric),
        new JdeField("JRPDBA", "JRPDBA", JdeDataType.Numeric),
        new JdeField("JRTARA", "JRTARA", JdeDataType.String, 20),
        new JdeField("JRPTAX", "JRPTAX", JdeDataType.String, 4),
        new JdeField("JRUN", "JRUN", JdeDataType.String, 12),
        new JdeField("JRWANO", "JRWANO", JdeDataType.Numeric),
        new JdeField("JRDEDM", "JRDEDM", JdeDataType.String, 2),
        new JdeField("JRGPA", "JRGPA", JdeDataType.Numeric),
        new JdeField("JRCO", "JRCO", JdeDataType.String, 10),
        new JdeField("JRMCU", "JRMCU", JdeDataType.String, 24),
        new JdeField("JROBJ", "JROBJ", JdeDataType.String, 12),
        new JdeField("JRSUB", "JRSUB", JdeDataType.String, 16),
        new JdeField("JRSBL", "JRSBL", JdeDataType.String, 16),
        new JdeField("JRSBLT", "JRSBLT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06490_0", "Primary Key on JRPRID, JRICU, JRANN8, JRAPTF, JRCTL2, JRANI", new[] { "JRPRID", "JRICU", "JRANN8", "JRAPTF", "JRCTL2", "JRANI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06490_2", "Index on JRPRID, JRICU, JRANN8, JRAPTF, JRCTL2, JRAN8", new[] { "JRPRID", "JRICU", "JRANN8", "JRAPTF", "JRCTL2", "JRAN8" }),
        new JdeIndex("F06490_3", "Index on JRAN8, JRCO, JRPRID, JRAPTF, JRCTL2", new[] { "JRAN8", "JRCO", "JRPRID", "JRAPTF", "JRCTL2" })
    };
}
