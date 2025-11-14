using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05WEBMM - .
/// </summary>
public class F05WEBMM : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMUSER.
        /// </summary>
        public const string WMUSER = "WMUSER";

        /// <summary>
        /// WMOBNM.
        /// </summary>
        public const string WMOBNM = "WMOBNM";

        /// <summary>
        /// WMWMID.
        /// </summary>
        public const string WMWMID = "WMWMID";

        /// <summary>
        /// WMUPMJ.
        /// </summary>
        public const string WMUPMJ = "WMUPMJ";

        /// <summary>
        /// WMUPMT.
        /// </summary>
        public const string WMUPMT = "WMUPMT";

        /// <summary>
        /// WMPID.
        /// </summary>
        public const string WMPID = "WMPID";

        /// <summary>
        /// WMJOBN.
        /// </summary>
        public const string WMJOBN = "WMJOBN";

        /// <summary>
        /// WMMMUID.
        /// </summary>
        public const string WMMMUID = "WMMMUID";

        /// <summary>
        /// WMMMDL.
        /// </summary>
        public const string WMMMDL = "WMMMDL";

        /// <summary>
        /// WMMMLC.
        /// </summary>
        public const string WMMMLC = "WMMMLC";
    }

    /// <inheritdoc />
    public override string TableName => "F05WEBMM";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMUSER", "WMUSER", JdeDataType.String, 20),
        new JdeField("WMOBNM", "WMOBNM", JdeDataType.String, 20),
        new JdeField("WMWMID", "WMWMID", JdeDataType.String, 90),
        new JdeField("WMUPMJ", "WMUPMJ", JdeDataType.Numeric),
        new JdeField("WMUPMT", "WMUPMT", JdeDataType.Numeric),
        new JdeField("WMPID", "WMPID", JdeDataType.String, 20),
        new JdeField("WMJOBN", "WMJOBN", JdeDataType.String, 20),
        new JdeField("WMMMUID", "WMMMUID", JdeDataType.Numeric, null, true, true),
        new JdeField("WMMMDL", "WMMMDL", JdeDataType.String, 2),
        new JdeField("WMMMLC", "WMMMLC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05WEBMM_0", "Primary Key on WMMMUID", new[] { "WMMMUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05WEBMM_2", "Index on WMUSER, WMOBNM, WMWMID", new[] { "WMUSER", "WMOBNM", "WMWMID" })
    };
}
