using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51010 - .
/// </summary>
public class F51010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSEXSYSINS.
        /// </summary>
        public const string CSEXSYSINS = "CSEXSYSINS";

        /// <summary>
        /// CSCMXMLF.
        /// </summary>
        public const string CSCMXMLF = "CSCMXMLF";

        /// <summary>
        /// CSCMFLOW.
        /// </summary>
        public const string CSCMFLOW = "CSCMFLOW";

        /// <summary>
        /// CSCMXFER.
        /// </summary>
        public const string CSCMXFER = "CSCMXFER";

        /// <summary>
        /// CSCXUTIME.
        /// </summary>
        public const string CSCXUTIME = "CSCXUTIME";

        /// <summary>
        /// CSCMPROC.
        /// </summary>
        public const string CSCMPROC = "CSCMPROC";

        /// <summary>
        /// CSCPUTIME.
        /// </summary>
        public const string CSCPUTIME = "CSCPUTIME";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSMKEY.
        /// </summary>
        public const string CSMKEY = "CSMKEY";

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
    public override string TableName => "F51010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSEXSYSINS", "CSEXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("CSCMXMLF", "CSCMXMLF", JdeDataType.String, 200, true, true),
        new JdeField("CSCMFLOW", "CSCMFLOW", JdeDataType.String, 2),
        new JdeField("CSCMXFER", "CSCMXFER", JdeDataType.String, 2),
        new JdeField("CSCXUTIME", "CSCXUTIME", JdeDataType.Date),
        new JdeField("CSCMPROC", "CSCMPROC", JdeDataType.String, 2),
        new JdeField("CSCPUTIME", "CSCPUTIME", JdeDataType.Date),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSMKEY", "CSMKEY", JdeDataType.String, 30),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51010_0", "Primary Key on CSEXSYSINS, CSCMXMLF", new[] { "CSEXSYSINS", "CSCMXMLF" }, isUnique: true, isPrimaryKey: true)
    };
}
