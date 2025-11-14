using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FH99PPOD - .
/// </summary>
public class FH99PPOD : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDOMWPRJID.
        /// </summary>
        public const string PDOMWPRJID = "PDOMWPRJID";

        /// <summary>
        /// PDOMWUSER.
        /// </summary>
        public const string PDOMWUSER = "PDOMWUSER";

        /// <summary>
        /// PDSY.
        /// </summary>
        public const string PDSY = "PDSY";

        /// <summary>
        /// PDOMWOBJID.
        /// </summary>
        public const string PDOMWOBJID = "PDOMWOBJID";

        /// <summary>
        /// PDOMWOT.
        /// </summary>
        public const string PDOMWOT = "PDOMWOT";

        /// <summary>
        /// PDPATHCD.
        /// </summary>
        public const string PDPATHCD = "PDPATHCD";

        /// <summary>
        /// PDNRPCHDJ.
        /// </summary>
        public const string PDNRPCHDJ = "PDNRPCHDJ";

        /// <summary>
        /// PDSRCRLS.
        /// </summary>
        public const string PDSRCRLS = "PDSRCRLS";

        /// <summary>
        /// PDCOMMENTS.
        /// </summary>
        public const string PDCOMMENTS = "PDCOMMENTS";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBS.
        /// </summary>
        public const string PDJOBS = "PDJOBS";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FH99PPOD";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDOMWPRJID", "PDOMWPRJID", JdeDataType.String, 60, true, true),
        new JdeField("PDOMWUSER", "PDOMWUSER", JdeDataType.String, 20),
        new JdeField("PDSY", "PDSY", JdeDataType.String, 8),
        new JdeField("PDOMWOBJID", "PDOMWOBJID", JdeDataType.String, 400, true, true),
        new JdeField("PDOMWOT", "PDOMWOT", JdeDataType.String, 20, true, true),
        new JdeField("PDPATHCD", "PDPATHCD", JdeDataType.String, 20),
        new JdeField("PDNRPCHDJ", "PDNRPCHDJ", JdeDataType.Numeric),
        new JdeField("PDSRCRLS", "PDSRCRLS", JdeDataType.String, 20),
        new JdeField("PDCOMMENTS", "PDCOMMENTS", JdeDataType.String, 512),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBS", "PDJOBS", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FH99PPOD_0", "Primary Key on PDOMWOT, PDOMWOBJID, PDOMWPRJID", new[] { "PDOMWOT", "PDOMWOBJID", "PDOMWPRJID" }, isUnique: true, isPrimaryKey: true)
    };
}
