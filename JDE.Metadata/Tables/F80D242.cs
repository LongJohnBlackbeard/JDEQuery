using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D242 - .
/// </summary>
public class F80D242 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRPRDJ.
        /// </summary>
        public const string PRPRDJ = "PRPRDJ";

        /// <summary>
        /// PREMCU.
        /// </summary>
        public const string PREMCU = "PREMCU";

        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRITM.
        /// </summary>
        public const string PRITM = "PRITM";

        /// <summary>
        /// PRPRRV.
        /// </summary>
        public const string PRPRRV = "PRPRRV";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRMKEY.
        /// </summary>
        public const string PRMKEY = "PRMKEY";

        /// <summary>
        /// PRUTIME.
        /// </summary>
        public const string PRUTIME = "PRUTIME";

        /// <summary>
        /// PRURCD.
        /// </summary>
        public const string PRURCD = "PRURCD";

        /// <summary>
        /// PRURDT.
        /// </summary>
        public const string PRURDT = "PRURDT";

        /// <summary>
        /// PRURAT.
        /// </summary>
        public const string PRURAT = "PRURAT";

        /// <summary>
        /// PRURAB.
        /// </summary>
        public const string PRURAB = "PRURAB";

        /// <summary>
        /// PRURRF.
        /// </summary>
        public const string PRURRF = "PRURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D242";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRPRDJ", "PRPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PREMCU", "PREMCU", JdeDataType.String, 24, true, true),
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PRITM", "PRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PRPRRV", "PRPRRV", JdeDataType.Numeric),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRMKEY", "PRMKEY", JdeDataType.String, 30),
        new JdeField("PRUTIME", "PRUTIME", JdeDataType.Date),
        new JdeField("PRURCD", "PRURCD", JdeDataType.String, 4),
        new JdeField("PRURDT", "PRURDT", JdeDataType.Numeric),
        new JdeField("PRURAT", "PRURAT", JdeDataType.Numeric),
        new JdeField("PRURAB", "PRURAB", JdeDataType.Numeric),
        new JdeField("PRURRF", "PRURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D242_0", "Primary Key on PRPRDJ, PREMCU, PRAN8, PRITM", new[] { "PRPRDJ", "PREMCU", "PRAN8", "PRITM" }, isUnique: true, isPrimaryKey: true)
    };
}
