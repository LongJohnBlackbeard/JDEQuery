using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI18 - .
/// </summary>
public class F76AUI18 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFKCOO.
        /// </summary>
        public const string WFKCOO = "WFKCOO";

        /// <summary>
        /// WFDCTO.
        /// </summary>
        public const string WFDCTO = "WFDCTO";

        /// <summary>
        /// WFDOCO.
        /// </summary>
        public const string WFDOCO = "WFDOCO";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFATXC.
        /// </summary>
        public const string WFATXC = "WFATXC";

        /// <summary>
        /// WFATDA.
        /// </summary>
        public const string WFATDA = "WFATDA";

        /// <summary>
        /// WFATFA.
        /// </summary>
        public const string WFATFA = "WFATFA";

        /// <summary>
        /// WFTXR1.
        /// </summary>
        public const string WFTXR1 = "WFTXR1";

        /// <summary>
        /// WFAUMT.
        /// </summary>
        public const string WFAUMT = "WFAUMT";

        /// <summary>
        /// WFUOM.
        /// </summary>
        public const string WFUOM = "WFUOM";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI18";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFKCOO", "WFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WFDCTO", "WFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WFDOCO", "WFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFATXC", "WFATXC", JdeDataType.String, 20, true, true),
        new JdeField("WFATDA", "WFATDA", JdeDataType.Numeric),
        new JdeField("WFATFA", "WFATFA", JdeDataType.Numeric),
        new JdeField("WFTXR1", "WFTXR1", JdeDataType.Numeric),
        new JdeField("WFAUMT", "WFAUMT", JdeDataType.Numeric),
        new JdeField("WFUOM", "WFUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI18_0", "Primary Key on WFCTID, WFJOBS, WFKCOO, WFDCTO, WFDOCO, WFLNID, WFATXC", new[] { "WFCTID", "WFJOBS", "WFKCOO", "WFDCTO", "WFDOCO", "WFLNID", "WFATXC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76AUI18_2", "Index on WFJOBS, WFCTID, WFKCOO, WFDCTO, WFDOCO, WFATXC, WFLNID", new[] { "WFJOBS", "WFCTID", "WFKCOO", "WFDCTO", "WFDOCO", "WFATXC", "WFLNID" }),
        new JdeIndex("F76AUI18_3", "Index on WFJOBS, WFCTID, WFKCOO, WFDCTO, WFDOCO, WFATXC", new[] { "WFJOBS", "WFCTID", "WFKCOO", "WFDCTO", "WFDOCO", "WFATXC" })
    };
}
