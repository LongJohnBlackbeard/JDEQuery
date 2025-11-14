using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G021 - .
/// </summary>
public class F40G021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SBSBLUID.
        /// </summary>
        public const string SBSBLUID = "SBSBLUID";

        /// <summary>
        /// SBBLUID.
        /// </summary>
        public const string SBBLUID = "SBBLUID";

        /// <summary>
        /// SBDESC.
        /// </summary>
        public const string SBDESC = "SBDESC";

        /// <summary>
        /// SBURCD.
        /// </summary>
        public const string SBURCD = "SBURCD";

        /// <summary>
        /// SBURDT.
        /// </summary>
        public const string SBURDT = "SBURDT";

        /// <summary>
        /// SBURRF.
        /// </summary>
        public const string SBURRF = "SBURRF";

        /// <summary>
        /// SBURAT.
        /// </summary>
        public const string SBURAT = "SBURAT";

        /// <summary>
        /// SBURAB.
        /// </summary>
        public const string SBURAB = "SBURAB";

        /// <summary>
        /// SBPID.
        /// </summary>
        public const string SBPID = "SBPID";

        /// <summary>
        /// SBTORG.
        /// </summary>
        public const string SBTORG = "SBTORG";

        /// <summary>
        /// SBUSER.
        /// </summary>
        public const string SBUSER = "SBUSER";

        /// <summary>
        /// SBJOBN.
        /// </summary>
        public const string SBJOBN = "SBJOBN";

        /// <summary>
        /// SBUUPMJ.
        /// </summary>
        public const string SBUUPMJ = "SBUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SBSBLUID", "SBSBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("SBBLUID", "SBBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("SBDESC", "SBDESC", JdeDataType.String, 60),
        new JdeField("SBURCD", "SBURCD", JdeDataType.String, 4),
        new JdeField("SBURDT", "SBURDT", JdeDataType.Numeric),
        new JdeField("SBURRF", "SBURRF", JdeDataType.String, 30),
        new JdeField("SBURAT", "SBURAT", JdeDataType.Numeric),
        new JdeField("SBURAB", "SBURAB", JdeDataType.Numeric),
        new JdeField("SBPID", "SBPID", JdeDataType.String, 20),
        new JdeField("SBTORG", "SBTORG", JdeDataType.String, 20),
        new JdeField("SBUSER", "SBUSER", JdeDataType.String, 20),
        new JdeField("SBJOBN", "SBJOBN", JdeDataType.String, 20),
        new JdeField("SBUUPMJ", "SBUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G021_0", "Primary Key on SBBLUID, SBSBLUID", new[] { "SBBLUID", "SBSBLUID" }, isUnique: true, isPrimaryKey: true)
    };
}
