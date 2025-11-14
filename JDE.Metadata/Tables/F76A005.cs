using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A005 - .
/// </summary>
public class F76A005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHCO.
        /// </summary>
        public const string RHCO = "RHCO";

        /// <summary>
        /// RHADGI.
        /// </summary>
        public const string RHADGI = "RHADGI";

        /// <summary>
        /// RHACEM.
        /// </summary>
        public const string RHACEM = "RHACEM";

        /// <summary>
        /// RHEFTJ.
        /// </summary>
        public const string RHEFTJ = "RHEFTJ";

        /// <summary>
        /// RHDOC1.
        /// </summary>
        public const string RHDOC1 = "RHDOC1";

        /// <summary>
        /// RHDOC2.
        /// </summary>
        public const string RHDOC2 = "RHDOC2";

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
        /// RHTDAY.
        /// </summary>
        public const string RHTDAY = "RHTDAY";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHADGI1.
        /// </summary>
        public const string RHADGI1 = "RHADGI1";

        /// <summary>
        /// RHACEM1.
        /// </summary>
        public const string RHACEM1 = "RHACEM1";
    }

    /// <inheritdoc />
    public override string TableName => "F76A005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHCO", "RHCO", JdeDataType.String, 10, true, true),
        new JdeField("RHADGI", "RHADGI", JdeDataType.String, 4, true, true),
        new JdeField("RHACEM", "RHACEM", JdeDataType.String, 8, true, true),
        new JdeField("RHEFTJ", "RHEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RHDOC1", "RHDOC1", JdeDataType.Numeric),
        new JdeField("RHDOC2", "RHDOC2", JdeDataType.Numeric),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHTDAY", "RHTDAY", JdeDataType.Numeric),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHADGI1", "RHADGI1", JdeDataType.String, 20, true, true),
        new JdeField("RHACEM1", "RHACEM1", JdeDataType.String, 30, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A005_0", "Primary Key on RHCO, RHADGI1, RHACEM1, RHEFTJ, RHADGI, RHACEM", new[] { "RHCO", "RHADGI1", "RHACEM1", "RHEFTJ", "RHADGI", "RHACEM" }, isUnique: true, isPrimaryKey: true)
    };
}
