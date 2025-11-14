using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI98 - .
/// </summary>
public class F76AUI98 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAJOBS.
        /// </summary>
        public const string CAJOBS = "CAJOBS";

        /// <summary>
        /// CACTID.
        /// </summary>
        public const string CACTID = "CACTID";

        /// <summary>
        /// CAMCU.
        /// </summary>
        public const string CAMCU = "CAMCU";

        /// <summary>
        /// CAOBJ.
        /// </summary>
        public const string CAOBJ = "CAOBJ";

        /// <summary>
        /// CASUB.
        /// </summary>
        public const string CASUB = "CASUB";

        /// <summary>
        /// CAAA.
        /// </summary>
        public const string CAAA = "CAAA";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI98";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAJOBS", "CAJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CACTID", "CACTID", JdeDataType.String, 30, true, true),
        new JdeField("CAMCU", "CAMCU", JdeDataType.String, 24, true, true),
        new JdeField("CAOBJ", "CAOBJ", JdeDataType.String, 12, true, true),
        new JdeField("CASUB", "CASUB", JdeDataType.String, 16, true, true),
        new JdeField("CAAA", "CAAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI98_0", "Primary Key on CAJOBS, CACTID, CAMCU, CAOBJ, CASUB", new[] { "CAJOBS", "CACTID", "CAMCU", "CAOBJ", "CASUB" }, isUnique: true, isPrimaryKey: true)
    };
}
