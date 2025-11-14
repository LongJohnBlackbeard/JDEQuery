using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H008 - .
/// </summary>
public class F76H008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSH76LECO.
        /// </summary>
        public const string CSH76LECO = "CSH76LECO";

        /// <summary>
        /// CSH76REDD.
        /// </summary>
        public const string CSH76REDD = "CSH76REDD";

        /// <summary>
        /// CSH76REMF.
        /// </summary>
        public const string CSH76REMF = "CSH76REMF";

        /// <summary>
        /// CSH76RETX.
        /// </summary>
        public const string CSH76RETX = "CSH76RETX";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSH76LECO", "CSH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("CSH76REDD", "CSH76REDD", JdeDataType.Numeric),
        new JdeField("CSH76REMF", "CSH76REMF", JdeDataType.String, 2),
        new JdeField("CSH76RETX", "CSH76RETX", JdeDataType.String, 4),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H008_0", "Primary Key on CSH76LECO", new[] { "CSH76LECO" }, isUnique: true, isPrimaryKey: true)
    };
}
