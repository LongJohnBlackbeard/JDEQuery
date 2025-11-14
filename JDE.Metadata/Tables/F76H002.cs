using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H002 - .
/// </summary>
public class F76H002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COH76LECO.
        /// </summary>
        public const string COH76LECO = "COH76LECO";

        /// <summary>
        /// COH76RESD.
        /// </summary>
        public const string COH76RESD = "COH76RESD";

        /// <summary>
        /// COH76REGL.
        /// </summary>
        public const string COH76REGL = "COH76REGL";

        /// <summary>
        /// COH76REDD.
        /// </summary>
        public const string COH76REDD = "COH76REDD";

        /// <summary>
        /// COH76REMF.
        /// </summary>
        public const string COH76REMF = "COH76REMF";

        /// <summary>
        /// COH76RETX.
        /// </summary>
        public const string COH76RETX = "COH76RETX";

        /// <summary>
        /// COH76WPF.
        /// </summary>
        public const string COH76WPF = "COH76WPF";

        /// <summary>
        /// COH76PFMN.
        /// </summary>
        public const string COH76PFMN = "COH76PFMN";

        /// <summary>
        /// COH76ARCC.
        /// </summary>
        public const string COH76ARCC = "COH76ARCC";

        /// <summary>
        /// COH76AS01.
        /// </summary>
        public const string COH76AS01 = "COH76AS01";

        /// <summary>
        /// COH76AS02.
        /// </summary>
        public const string COH76AS02 = "COH76AS02";

        /// <summary>
        /// COH76FUA.
        /// </summary>
        public const string COH76FUA = "COH76FUA";

        /// <summary>
        /// COH76FUC.
        /// </summary>
        public const string COH76FUC = "COH76FUC";

        /// <summary>
        /// COH76FUD.
        /// </summary>
        public const string COH76FUD = "COH76FUD";

        /// <summary>
        /// COH76FUR.
        /// </summary>
        public const string COH76FUR = "COH76FUR";

        /// <summary>
        /// COH76FUF.
        /// </summary>
        public const string COH76FUF = "COH76FUF";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COJOBN.
        /// </summary>
        public const string COJOBN = "COJOBN";

        /// <summary>
        /// COUPMJ.
        /// </summary>
        public const string COUPMJ = "COUPMJ";

        /// <summary>
        /// COUPMT.
        /// </summary>
        public const string COUPMT = "COUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COH76LECO", "COH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("COH76RESD", "COH76RESD", JdeDataType.String, 2),
        new JdeField("COH76REGL", "COH76REGL", JdeDataType.String, 2),
        new JdeField("COH76REDD", "COH76REDD", JdeDataType.Numeric),
        new JdeField("COH76REMF", "COH76REMF", JdeDataType.String, 2),
        new JdeField("COH76RETX", "COH76RETX", JdeDataType.String, 4),
        new JdeField("COH76WPF", "COH76WPF", JdeDataType.String, 2),
        new JdeField("COH76PFMN", "COH76PFMN", JdeDataType.Numeric),
        new JdeField("COH76ARCC", "COH76ARCC", JdeDataType.Numeric),
        new JdeField("COH76AS01", "COH76AS01", JdeDataType.Numeric),
        new JdeField("COH76AS02", "COH76AS02", JdeDataType.Numeric),
        new JdeField("COH76FUA", "COH76FUA", JdeDataType.Numeric),
        new JdeField("COH76FUC", "COH76FUC", JdeDataType.String, 20),
        new JdeField("COH76FUD", "COH76FUD", JdeDataType.Numeric),
        new JdeField("COH76FUR", "COH76FUR", JdeDataType.String, 30),
        new JdeField("COH76FUF", "COH76FUF", JdeDataType.String, 2),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COJOBN", "COJOBN", JdeDataType.String, 20),
        new JdeField("COUPMJ", "COUPMJ", JdeDataType.Numeric),
        new JdeField("COUPMT", "COUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H002_0", "Primary Key on COH76LECO", new[] { "COH76LECO" }, isUnique: true, isPrimaryKey: true)
    };
}
