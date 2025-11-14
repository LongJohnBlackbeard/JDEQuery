using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07940 - .
/// </summary>
public class F07940 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YYPTAX.
        /// </summary>
        public const string YYPTAX = "YYPTAX";

        /// <summary>
        /// YYVTFC.
        /// </summary>
        public const string YYVTFC = "YYVTFC";

        /// <summary>
        /// YYVTCD.
        /// </summary>
        public const string YYVTCD = "YYVTCD";

        /// <summary>
        /// YYCTR.
        /// </summary>
        public const string YYCTR = "YYCTR";

        /// <summary>
        /// YYVTAX.
        /// </summary>
        public const string YYVTAX = "YYVTAX";

        /// <summary>
        /// YYEVTI.
        /// </summary>
        public const string YYEVTI = "YYEVTI";

        /// <summary>
        /// YYVTTP.
        /// </summary>
        public const string YYVTTP = "YYVTTP";

        /// <summary>
        /// YYVFNC.
        /// </summary>
        public const string YYVFNC = "YYVFNC";

        /// <summary>
        /// YYUPMJ.
        /// </summary>
        public const string YYUPMJ = "YYUPMJ";

        /// <summary>
        /// YYUPMT.
        /// </summary>
        public const string YYUPMT = "YYUPMT";

        /// <summary>
        /// YYPID2.
        /// </summary>
        public const string YYPID2 = "YYPID2";

        /// <summary>
        /// YYJOBN.
        /// </summary>
        public const string YYJOBN = "YYJOBN";

        /// <summary>
        /// YYUSER.
        /// </summary>
        public const string YYUSER = "YYUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07940";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YYPTAX", "YYPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YYVTFC", "YYVTFC", JdeDataType.String, 8, true, true),
        new JdeField("YYVTCD", "YYVTCD", JdeDataType.String, 6, true, true),
        new JdeField("YYCTR", "YYCTR", JdeDataType.String, 6),
        new JdeField("YYVTAX", "YYVTAX", JdeDataType.String, 8),
        new JdeField("YYEVTI", "YYEVTI", JdeDataType.String, 30),
        new JdeField("YYVTTP", "YYVTTP", JdeDataType.String, 6),
        new JdeField("YYVFNC", "YYVFNC", JdeDataType.String, 40),
        new JdeField("YYUPMJ", "YYUPMJ", JdeDataType.Numeric),
        new JdeField("YYUPMT", "YYUPMT", JdeDataType.Numeric),
        new JdeField("YYPID2", "YYPID2", JdeDataType.String, 20),
        new JdeField("YYJOBN", "YYJOBN", JdeDataType.String, 20),
        new JdeField("YYUSER", "YYUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07940_0", "Primary Key on YYPTAX, YYVTFC, YYVTCD", new[] { "YYPTAX", "YYVTFC", "YYVTCD" }, isUnique: true, isPrimaryKey: true)
    };
}
