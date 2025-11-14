using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4015 - .
/// </summary>
public class F74U4015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRAN8.
        /// </summary>
        public const string IRAN8 = "IRAN8";

        /// <summary>
        /// IRU74LAN8.
        /// </summary>
        public const string IRU74LAN8 = "IRU74LAN8";

        /// <summary>
        /// IRU74LSCF.
        /// </summary>
        public const string IRU74LSCF = "IRU74LSCF";

        /// <summary>
        /// IRUSER.
        /// </summary>
        public const string IRUSER = "IRUSER";

        /// <summary>
        /// IRPID.
        /// </summary>
        public const string IRPID = "IRPID";

        /// <summary>
        /// IRUPMJ.
        /// </summary>
        public const string IRUPMJ = "IRUPMJ";

        /// <summary>
        /// IRUPMT.
        /// </summary>
        public const string IRUPMT = "IRUPMT";

        /// <summary>
        /// IRJOBN.
        /// </summary>
        public const string IRJOBN = "IRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRAN8", "IRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("IRU74LAN8", "IRU74LAN8", JdeDataType.Numeric),
        new JdeField("IRU74LSCF", "IRU74LSCF", JdeDataType.String, 2),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRUPMT", "IRUPMT", JdeDataType.Numeric),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4015_0", "Primary Key on IRAN8", new[] { "IRAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U4015_3", "Index on IRU74LAN8, IRU74LSCF", new[] { "IRU74LAN8", "IRU74LSCF" })
    };
}
