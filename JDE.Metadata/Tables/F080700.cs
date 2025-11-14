using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080700 - .
/// </summary>
public class F080700 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XRCONFID.
        /// </summary>
        public const string XRCONFID = "XRCONFID";

        /// <summary>
        /// XRENTNM.
        /// </summary>
        public const string XRENTNM = "XRENTNM";

        /// <summary>
        /// XRFUSGUID.
        /// </summary>
        public const string XRFUSGUID = "XRFUSGUID";

        /// <summary>
        /// XRFUSID.
        /// </summary>
        public const string XRFUSID = "XRFUSID";

        /// <summary>
        /// XRSORCID.
        /// </summary>
        public const string XRSORCID = "XRSORCID";

        /// <summary>
        /// XRDSE1.
        /// </summary>
        public const string XRDSE1 = "XRDSE1";

        /// <summary>
        /// XRDSE2.
        /// </summary>
        public const string XRDSE2 = "XRDSE2";

        /// <summary>
        /// XRUPMJ.
        /// </summary>
        public const string XRUPMJ = "XRUPMJ";

        /// <summary>
        /// XRUPMT.
        /// </summary>
        public const string XRUPMT = "XRUPMT";

        /// <summary>
        /// XRUSER.
        /// </summary>
        public const string XRUSER = "XRUSER";

        /// <summary>
        /// XRJOBN.
        /// </summary>
        public const string XRJOBN = "XRJOBN";

        /// <summary>
        /// XRPID.
        /// </summary>
        public const string XRPID = "XRPID";
    }

    /// <inheritdoc />
    public override string TableName => "F080700";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XRCONFID", "XRCONFID", JdeDataType.Numeric, null, true, true),
        new JdeField("XRENTNM", "XRENTNM", JdeDataType.String, 80, true, true),
        new JdeField("XRFUSGUID", "XRFUSGUID", JdeDataType.String, 100, true, true),
        new JdeField("XRFUSID", "XRFUSID", JdeDataType.Numeric),
        new JdeField("XRSORCID", "XRSORCID", JdeDataType.Numeric),
        new JdeField("XRDSE1", "XRDSE1", JdeDataType.String, 80),
        new JdeField("XRDSE2", "XRDSE2", JdeDataType.String, 80),
        new JdeField("XRUPMJ", "XRUPMJ", JdeDataType.Numeric),
        new JdeField("XRUPMT", "XRUPMT", JdeDataType.Numeric),
        new JdeField("XRUSER", "XRUSER", JdeDataType.String, 20),
        new JdeField("XRJOBN", "XRJOBN", JdeDataType.String, 20),
        new JdeField("XRPID", "XRPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080700_0", "Primary Key on XRCONFID, XRENTNM, XRFUSGUID", new[] { "XRCONFID", "XRENTNM", "XRFUSGUID" }, isUnique: true, isPrimaryKey: true)
    };
}
