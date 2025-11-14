using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CG001 - .
/// </summary>
public class F90CG001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APPARMID.
        /// </summary>
        public const string APPARMID = "APPARMID";

        /// <summary>
        /// APPARMNAME.
        /// </summary>
        public const string APPARMNAME = "APPARMNAME";

        /// <summary>
        /// APPARMNUM.
        /// </summary>
        public const string APPARMNUM = "APPARMNUM";

        /// <summary>
        /// APPARMTITLE.
        /// </summary>
        public const string APPARMTITLE = "APPARMTITLE";

        /// <summary>
        /// APURLID.
        /// </summary>
        public const string APURLID = "APURLID";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APUDTTM.
        /// </summary>
        public const string APUDTTM = "APUDTTM";

        /// <summary>
        /// APMKEY.
        /// </summary>
        public const string APMKEY = "APMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CG001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APPARMID", "APPARMID", JdeDataType.Numeric, null, true, true),
        new JdeField("APPARMNAME", "APPARMNAME", JdeDataType.String, 510),
        new JdeField("APPARMNUM", "APPARMNUM", JdeDataType.Numeric),
        new JdeField("APPARMTITLE", "APPARMTITLE", JdeDataType.String, 510),
        new JdeField("APURLID", "APURLID", JdeDataType.Numeric),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APUDTTM", "APUDTTM", JdeDataType.Date),
        new JdeField("APMKEY", "APMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CG001_0", "Primary Key on APPARMID", new[] { "APPARMID" }, isUnique: true, isPrimaryKey: true)
    };
}
