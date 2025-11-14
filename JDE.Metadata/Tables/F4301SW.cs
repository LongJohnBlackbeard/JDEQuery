using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4301SW - .
/// </summary>
public class F4301SW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSUKID.
        /// </summary>
        public const string PSUKID = "PSUKID";

        /// <summary>
        /// PSAN8.
        /// </summary>
        public const string PSAN8 = "PSAN8";

        /// <summary>
        /// PSCRCD.
        /// </summary>
        public const string PSCRCD = "PSCRCD";

        /// <summary>
        /// PSMCU.
        /// </summary>
        public const string PSMCU = "PSMCU";

        /// <summary>
        /// PSCRDC.
        /// </summary>
        public const string PSCRDC = "PSCRDC";

        /// <summary>
        /// PSOTOT.
        /// </summary>
        public const string PSOTOT = "PSOTOT";

        /// <summary>
        /// PSFAP.
        /// </summary>
        public const string PSFAP = "PSFAP";
    }

    /// <inheritdoc />
    public override string TableName => "F4301SW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20, true, true),
        new JdeField("PSUKID", "PSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PSAN8", "PSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PSCRCD", "PSCRCD", JdeDataType.String, 6, true, true),
        new JdeField("PSMCU", "PSMCU", JdeDataType.String, 24, true, true),
        new JdeField("PSCRDC", "PSCRDC", JdeDataType.String, 6, true, true),
        new JdeField("PSOTOT", "PSOTOT", JdeDataType.Numeric),
        new JdeField("PSFAP", "PSFAP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4301SW_0", "Primary Key on PSUSER, PSUKID, PSAN8, PSCRCD, PSMCU, PSCRDC", new[] { "PSUSER", "PSUKID", "PSAN8", "PSCRCD", "PSMCU", "PSCRDC" }, isUnique: true, isPrimaryKey: true)
    };
}
