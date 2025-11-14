using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F086401 - .
/// </summary>
public class F086401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHTYPRPT.
        /// </summary>
        public const string RHTYPRPT = "RHTYPRPT";

        /// <summary>
        /// RHJOBS.
        /// </summary>
        public const string RHJOBS = "RHJOBS";

        /// <summary>
        /// RHDL01.
        /// </summary>
        public const string RHDL01 = "RHDL01";

        /// <summary>
        /// RHEFT.
        /// </summary>
        public const string RHEFT = "RHEFT";

        /// <summary>
        /// RHEFTE.
        /// </summary>
        public const string RHEFTE = "RHEFTE";

        /// <summary>
        /// RHCALYEAR.
        /// </summary>
        public const string RHCALYEAR = "RHCALYEAR";

        /// <summary>
        /// RHRSEL.
        /// </summary>
        public const string RHRSEL = "RHRSEL";

        /// <summary>
        /// RHLNEST.
        /// </summary>
        public const string RHLNEST = "RHLNEST";

        /// <summary>
        /// RHETHNIC.
        /// </summary>
        public const string RHETHNIC = "RHETHNIC";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHUPMT.
        /// </summary>
        public const string RHUPMT = "RHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F086401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHTYPRPT", "RHTYPRPT", JdeDataType.String, 2, true, true),
        new JdeField("RHJOBS", "RHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RHDL01", "RHDL01", JdeDataType.String, 60),
        new JdeField("RHEFT", "RHEFT", JdeDataType.Numeric),
        new JdeField("RHEFTE", "RHEFTE", JdeDataType.Numeric),
        new JdeField("RHCALYEAR", "RHCALYEAR", JdeDataType.Numeric),
        new JdeField("RHRSEL", "RHRSEL", JdeDataType.String, 2),
        new JdeField("RHLNEST", "RHLNEST", JdeDataType.String, 2),
        new JdeField("RHETHNIC", "RHETHNIC", JdeDataType.String, 2),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHUPMT", "RHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F086401_0", "Primary Key on RHTYPRPT, RHJOBS", new[] { "RHTYPRPT", "RHJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
