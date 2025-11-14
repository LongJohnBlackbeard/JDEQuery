using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069016 - .
/// </summary>
public class F069016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YPTARA.
        /// </summary>
        public const string YPTARA = "YPTARA";

        /// <summary>
        /// YPDC.
        /// </summary>
        public const string YPDC = "YPDC";

        /// <summary>
        /// YPDSCA.
        /// </summary>
        public const string YPDSCA = "YPDSCA";

        /// <summary>
        /// YPPTAX.
        /// </summary>
        public const string YPPTAX = "YPPTAX";

        /// <summary>
        /// YPSCOD.
        /// </summary>
        public const string YPSCOD = "YPSCOD";

        /// <summary>
        /// YPANN8.
        /// </summary>
        public const string YPANN8 = "YPANN8";

        /// <summary>
        /// YPCE.
        /// </summary>
        public const string YPCE = "YPCE";

        /// <summary>
        /// YPPCK.
        /// </summary>
        public const string YPPCK = "YPPCK";

        /// <summary>
        /// YPUSER.
        /// </summary>
        public const string YPUSER = "YPUSER";

        /// <summary>
        /// YPPID.
        /// </summary>
        public const string YPPID = "YPPID";

        /// <summary>
        /// YPUPMJ.
        /// </summary>
        public const string YPUPMJ = "YPUPMJ";

        /// <summary>
        /// YPOTWF.
        /// </summary>
        public const string YPOTWF = "YPOTWF";

        /// <summary>
        /// YPSRL.
        /// </summary>
        public const string YPSRL = "YPSRL";

        /// <summary>
        /// YPSCDC.
        /// </summary>
        public const string YPSCDC = "YPSCDC";

        /// <summary>
        /// YPTXAR.
        /// </summary>
        public const string YPTXAR = "YPTXAR";

        /// <summary>
        /// YPTPRI.
        /// </summary>
        public const string YPTPRI = "YPTPRI";

        /// <summary>
        /// YPTXAL.
        /// </summary>
        public const string YPTXAL = "YPTXAL";

        /// <summary>
        /// YPTACC.
        /// </summary>
        public const string YPTACC = "YPTACC";

        /// <summary>
        /// YPDTAB.
        /// </summary>
        public const string YPDTAB = "YPDTAB";

        /// <summary>
        /// YPGVCH.
        /// </summary>
        public const string YPGVCH = "YPGVCH";

        /// <summary>
        /// YPDSE2.
        /// </summary>
        public const string YPDSE2 = "YPDSE2";
    }

    /// <inheritdoc />
    public override string TableName => "F069016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YPTARA", "YPTARA", JdeDataType.String, 20, true, true),
        new JdeField("YPDC", "YPDC", JdeDataType.String, 80),
        new JdeField("YPDSCA", "YPDSCA", JdeDataType.String, 80),
        new JdeField("YPPTAX", "YPPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YPSCOD", "YPSCOD", JdeDataType.String, 6),
        new JdeField("YPANN8", "YPANN8", JdeDataType.Numeric),
        new JdeField("YPCE", "YPCE", JdeDataType.String, 2),
        new JdeField("YPPCK", "YPPCK", JdeDataType.String, 2),
        new JdeField("YPUSER", "YPUSER", JdeDataType.String, 20),
        new JdeField("YPPID", "YPPID", JdeDataType.String, 20),
        new JdeField("YPUPMJ", "YPUPMJ", JdeDataType.Numeric),
        new JdeField("YPOTWF", "YPOTWF", JdeDataType.String, 2),
        new JdeField("YPSRL", "YPSRL", JdeDataType.String, 2),
        new JdeField("YPSCDC", "YPSCDC", JdeDataType.Numeric),
        new JdeField("YPTXAR", "YPTXAR", JdeDataType.String, 2),
        new JdeField("YPTPRI", "YPTPRI", JdeDataType.Numeric),
        new JdeField("YPTXAL", "YPTXAL", JdeDataType.Numeric),
        new JdeField("YPTACC", "YPTACC", JdeDataType.String, 4),
        new JdeField("YPDTAB", "YPDTAB", JdeDataType.String, 10),
        new JdeField("YPGVCH", "YPGVCH", JdeDataType.String, 2),
        new JdeField("YPDSE2", "YPDSE2", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069016_0", "Primary Key on YPTARA, YPPTAX", new[] { "YPTARA", "YPPTAX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069016_2", "Index on YPDC, YPTARA", new[] { "YPDC", "YPTARA" }),
        new JdeIndex("F069016_3", "Index on YPSCOD, YPPTAX", new[] { "YPSCOD", "YPPTAX" })
    };
}
