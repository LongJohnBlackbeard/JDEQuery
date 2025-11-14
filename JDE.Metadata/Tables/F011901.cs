using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F011901 - .
/// </summary>
public class F011901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSCFRGUID.
        /// </summary>
        public const string CSCFRGUID = "CSCFRGUID";

        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSIDLN.
        /// </summary>
        public const string CSIDLN = "CSIDLN";

        /// <summary>
        /// CSFLCC.
        /// </summary>
        public const string CSFLCC = "CSFLCC";

        /// <summary>
        /// CSFLAC.
        /// </summary>
        public const string CSFLAC = "CSFLAC";

        /// <summary>
        /// CSFLEC.
        /// </summary>
        public const string CSFLEC = "CSFLEC";

        /// <summary>
        /// CSFLRC.
        /// </summary>
        public const string CSFLRC = "CSFLRC";

        /// <summary>
        /// CSFLPC.
        /// </summary>
        public const string CSFLPC = "CSFLPC";

        /// <summary>
        /// CSFLNW.
        /// </summary>
        public const string CSFLNW = "CSFLNW";

        /// <summary>
        /// CSFDEL.
        /// </summary>
        public const string CSFDEL = "CSFDEL";

        /// <summary>
        /// CSSYTS.
        /// </summary>
        public const string CSSYTS = "CSSYTS";

        /// <summary>
        /// CSUSC.
        /// </summary>
        public const string CSUSC = "CSUSC";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F011901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20, true, true),
        new JdeField("CSCFRGUID", "CSCFRGUID", JdeDataType.String, 72, true, true),
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric),
        new JdeField("CSIDLN", "CSIDLN", JdeDataType.Numeric),
        new JdeField("CSFLCC", "CSFLCC", JdeDataType.String, 2),
        new JdeField("CSFLAC", "CSFLAC", JdeDataType.String, 2),
        new JdeField("CSFLEC", "CSFLEC", JdeDataType.String, 2),
        new JdeField("CSFLRC", "CSFLRC", JdeDataType.String, 2),
        new JdeField("CSFLPC", "CSFLPC", JdeDataType.String, 2),
        new JdeField("CSFLNW", "CSFLNW", JdeDataType.String, 2),
        new JdeField("CSFDEL", "CSFDEL", JdeDataType.String, 2),
        new JdeField("CSSYTS", "CSSYTS", JdeDataType.Date),
        new JdeField("CSUSC", "CSUSC", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F011901_0", "Primary Key on CSCFRGUID, CSUSER", new[] { "CSCFRGUID", "CSUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F011901_2", "Index on CSAN8, CSIDLN, CSUSER", new[] { "CSAN8", "CSIDLN", "CSUSER" })
    };
}
