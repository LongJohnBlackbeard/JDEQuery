using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4211SW - .
/// </summary>
public class F4211SW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSUSER.
        /// </summary>
        public const string SSUSER = "SSUSER";

        /// <summary>
        /// SSUKID.
        /// </summary>
        public const string SSUKID = "SSUKID";

        /// <summary>
        /// SSAN8.
        /// </summary>
        public const string SSAN8 = "SSAN8";

        /// <summary>
        /// SSITM.
        /// </summary>
        public const string SSITM = "SSITM";

        /// <summary>
        /// SSMCU.
        /// </summary>
        public const string SSMCU = "SSMCU";

        /// <summary>
        /// SSUOM.
        /// </summary>
        public const string SSUOM = "SSUOM";

        /// <summary>
        /// SSOBNM.
        /// </summary>
        public const string SSOBNM = "SSOBNM";

        /// <summary>
        /// SSUORG.
        /// </summary>
        public const string SSUORG = "SSUORG";

        /// <summary>
        /// SSSOQS.
        /// </summary>
        public const string SSSOQS = "SSSOQS";

        /// <summary>
        /// SSSOBK.
        /// </summary>
        public const string SSSOBK = "SSSOBK";

        /// <summary>
        /// SSSOCN.
        /// </summary>
        public const string SSSOCN = "SSSOCN";
    }

    /// <inheritdoc />
    public override string TableName => "F4211SW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSUSER", "SSUSER", JdeDataType.String, 20, true, true),
        new JdeField("SSUKID", "SSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SSAN8", "SSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SSITM", "SSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SSMCU", "SSMCU", JdeDataType.String, 24, true, true),
        new JdeField("SSUOM", "SSUOM", JdeDataType.String, 4, true, true),
        new JdeField("SSOBNM", "SSOBNM", JdeDataType.String, 20, true, true),
        new JdeField("SSUORG", "SSUORG", JdeDataType.Numeric),
        new JdeField("SSSOQS", "SSSOQS", JdeDataType.Numeric),
        new JdeField("SSSOBK", "SSSOBK", JdeDataType.Numeric),
        new JdeField("SSSOCN", "SSSOCN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4211SW_0", "Primary Key on SSUSER, SSUKID, SSAN8, SSITM, SSMCU, SSUOM, SSOBNM", new[] { "SSUSER", "SSUKID", "SSAN8", "SSITM", "SSMCU", "SSUOM", "SSOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
