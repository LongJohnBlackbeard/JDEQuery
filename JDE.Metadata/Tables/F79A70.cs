using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A70 - .
/// </summary>
public class F79A70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OH79AGHID.
        /// </summary>
        public const string OH79AGHID = "OH79AGHID";

        /// <summary>
        /// OH79AGHCD.
        /// </summary>
        public const string OH79AGHCD = "OH79AGHCD";

        /// <summary>
        /// OH79AGHNM.
        /// </summary>
        public const string OH79AGHNM = "OH79AGHNM";

        /// <summary>
        /// OH79AGHTY.
        /// </summary>
        public const string OH79AGHTY = "OH79AGHTY";

        /// <summary>
        /// OHBEFD.
        /// </summary>
        public const string OHBEFD = "OHBEFD";

        /// <summary>
        /// OHEEFD.
        /// </summary>
        public const string OHEEFD = "OHEEFD";

        /// <summary>
        /// OHPID.
        /// </summary>
        public const string OHPID = "OHPID";

        /// <summary>
        /// OHUSER.
        /// </summary>
        public const string OHUSER = "OHUSER";

        /// <summary>
        /// OHJOBN.
        /// </summary>
        public const string OHJOBN = "OHJOBN";

        /// <summary>
        /// OHUPMJ.
        /// </summary>
        public const string OHUPMJ = "OHUPMJ";

        /// <summary>
        /// OHTDAY.
        /// </summary>
        public const string OHTDAY = "OHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OH79AGHID", "OH79AGHID", JdeDataType.Numeric, null, true, true),
        new JdeField("OH79AGHCD", "OH79AGHCD", JdeDataType.String, 120),
        new JdeField("OH79AGHNM", "OH79AGHNM", JdeDataType.String, 200),
        new JdeField("OH79AGHTY", "OH79AGHTY", JdeDataType.String, 20),
        new JdeField("OHBEFD", "OHBEFD", JdeDataType.Numeric),
        new JdeField("OHEEFD", "OHEEFD", JdeDataType.Numeric),
        new JdeField("OHPID", "OHPID", JdeDataType.String, 20),
        new JdeField("OHUSER", "OHUSER", JdeDataType.String, 20),
        new JdeField("OHJOBN", "OHJOBN", JdeDataType.String, 20),
        new JdeField("OHUPMJ", "OHUPMJ", JdeDataType.Numeric),
        new JdeField("OHTDAY", "OHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A70_0", "Primary Key on OH79AGHID", new[] { "OH79AGHID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A70_2", "Index on OH79AGHCD, OHBEFD", new[] { "OH79AGHCD", "OHBEFD" }),
        new JdeIndex("F79A70_3", "Index on OH79AGHNM", new[] { "OH79AGHNM" }),
        new JdeIndex("F79A70_4", "Unique Index on OH79AGHCD", new[] { "OH79AGHCD" }, isUnique: true)
    };
}
