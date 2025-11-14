using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98OWNTU - .
/// </summary>
public class F98OWNTU : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NTAN8.
        /// </summary>
        public const string NTAN8 = "NTAN8";

        /// <summary>
        /// NTUSER.
        /// </summary>
        public const string NTUSER = "NTUSER";

        /// <summary>
        /// NTDOMNAME.
        /// </summary>
        public const string NTDOMNAME = "NTDOMNAME";

        /// <summary>
        /// NTSECFUT7.
        /// </summary>
        public const string NTSECFUT7 = "NTSECFUT7";

        /// <summary>
        /// NTSECFUT8.
        /// </summary>
        public const string NTSECFUT8 = "NTSECFUT8";

        /// <summary>
        /// NTSECFUT9.
        /// </summary>
        public const string NTSECFUT9 = "NTSECFUT9";

        /// <summary>
        /// NTSECFUT10.
        /// </summary>
        public const string NTSECFUT10 = "NTSECFUT10";

        /// <summary>
        /// NTSECFUT11.
        /// </summary>
        public const string NTSECFUT11 = "NTSECFUT11";

        /// <summary>
        /// NTSECFUT12.
        /// </summary>
        public const string NTSECFUT12 = "NTSECFUT12";

        /// <summary>
        /// NTMUSE.
        /// </summary>
        public const string NTMUSE = "NTMUSE";

        /// <summary>
        /// NTPID.
        /// </summary>
        public const string NTPID = "NTPID";

        /// <summary>
        /// NTJOBN.
        /// </summary>
        public const string NTJOBN = "NTJOBN";

        /// <summary>
        /// NTUPMJ.
        /// </summary>
        public const string NTUPMJ = "NTUPMJ";

        /// <summary>
        /// NTUPMT.
        /// </summary>
        public const string NTUPMT = "NTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F98OWNTU";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NTAN8", "NTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NTUSER", "NTUSER", JdeDataType.String, 20),
        new JdeField("NTDOMNAME", "NTDOMNAME", JdeDataType.String, 30),
        new JdeField("NTSECFUT7", "NTSECFUT7", JdeDataType.String, 2),
        new JdeField("NTSECFUT8", "NTSECFUT8", JdeDataType.String, 2),
        new JdeField("NTSECFUT9", "NTSECFUT9", JdeDataType.String, 20),
        new JdeField("NTSECFUT10", "NTSECFUT10", JdeDataType.String, 20),
        new JdeField("NTSECFUT11", "NTSECFUT11", JdeDataType.Numeric),
        new JdeField("NTSECFUT12", "NTSECFUT12", JdeDataType.Numeric),
        new JdeField("NTMUSE", "NTMUSE", JdeDataType.String, 20),
        new JdeField("NTPID", "NTPID", JdeDataType.String, 20),
        new JdeField("NTJOBN", "NTJOBN", JdeDataType.String, 20),
        new JdeField("NTUPMJ", "NTUPMJ", JdeDataType.Numeric),
        new JdeField("NTUPMT", "NTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98OWNTU_0", "Primary Key on NTAN8", new[] { "NTAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F98OWNTU_2", "Index on NTUSER", new[] { "NTUSER" })
    };
}
