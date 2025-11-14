using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1642 - .
/// </summary>
public class F1642 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHLT.
        /// </summary>
        public const string RHLT = "RHLT";

        /// <summary>
        /// RHCO.
        /// </summary>
        public const string RHCO = "RHCO";

        /// <summary>
        /// RHMCU.
        /// </summary>
        public const string RHMCU = "RHMCU";

        /// <summary>
        /// RHCSPL.
        /// </summary>
        public const string RHCSPL = "RHCSPL";

        /// <summary>
        /// RHACTB.
        /// </summary>
        public const string RHACTB = "RHACTB";

        /// <summary>
        /// RHDRCD.
        /// </summary>
        public const string RHDRCD = "RHDRCD";

        /// <summary>
        /// RHEFFF.
        /// </summary>
        public const string RHEFFF = "RHEFFF";

        /// <summary>
        /// RHCOST.
        /// </summary>
        public const string RHCOST = "RHCOST";

        /// <summary>
        /// RHLEDG.
        /// </summary>
        public const string RHLEDG = "RHLEDG";

        /// <summary>
        /// RHDL01.
        /// </summary>
        public const string RHDL01 = "RHDL01";

        /// <summary>
        /// RHRHID.
        /// </summary>
        public const string RHRHID = "RHRHID";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHUPMT.
        /// </summary>
        public const string RHUPMT = "RHUPMT";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1642";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHLT", "RHLT", JdeDataType.String, 4, true, true),
        new JdeField("RHCO", "RHCO", JdeDataType.String, 10, true, true),
        new JdeField("RHMCU", "RHMCU", JdeDataType.String, 24, true, true),
        new JdeField("RHCSPL", "RHCSPL", JdeDataType.String, 20, true, true),
        new JdeField("RHACTB", "RHACTB", JdeDataType.String, 20, true, true),
        new JdeField("RHDRCD", "RHDRCD", JdeDataType.String, 20, true, true),
        new JdeField("RHEFFF", "RHEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("RHCOST", "RHCOST", JdeDataType.String, 6),
        new JdeField("RHLEDG", "RHLEDG", JdeDataType.String, 4),
        new JdeField("RHDL01", "RHDL01", JdeDataType.String, 60),
        new JdeField("RHRHID", "RHRHID", JdeDataType.Numeric),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHUPMT", "RHUPMT", JdeDataType.Numeric),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1642_0", "Primary Key on RHLT, RHCO, RHMCU, RHCSPL, RHACTB, RHDRCD, RHEFFF", new[] { "RHLT", "RHCO", "RHMCU", "RHCSPL", "RHACTB", "RHDRCD", "RHEFFF" }, isUnique: true, isPrimaryKey: true)
    };
}
