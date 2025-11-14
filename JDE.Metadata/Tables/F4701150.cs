using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4701150 - .
/// </summary>
public class F4701150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHDOCO.
        /// </summary>
        public const string PHDOCO = "PHDOCO";

        /// <summary>
        /// PHDCTO.
        /// </summary>
        public const string PHDCTO = "PHDCTO";

        /// <summary>
        /// PHKCOO.
        /// </summary>
        public const string PHKCOO = "PHKCOO";

        /// <summary>
        /// PHCMLN.
        /// </summary>
        public const string PHCMLN = "PHCMLN";

        /// <summary>
        /// PHSLSM.
        /// </summary>
        public const string PHSLSM = "PHSLSM";

        /// <summary>
        /// PHSLCM.
        /// </summary>
        public const string PHSLCM = "PHSLCM";

        /// <summary>
        /// PHFCA.
        /// </summary>
        public const string PHFCA = "PHFCA";

        /// <summary>
        /// PHAPUN.
        /// </summary>
        public const string PHAPUN = "PHAPUN";

        /// <summary>
        /// PHCCTY.
        /// </summary>
        public const string PHCCTY = "PHCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4701150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHDOCO", "PHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PHDCTO", "PHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PHKCOO", "PHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PHCMLN", "PHCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PHSLSM", "PHSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("PHSLCM", "PHSLCM", JdeDataType.Numeric),
        new JdeField("PHFCA", "PHFCA", JdeDataType.Numeric),
        new JdeField("PHAPUN", "PHAPUN", JdeDataType.Numeric),
        new JdeField("PHCCTY", "PHCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4701150_0", "Primary Key on PHDOCO, PHDCTO, PHKCOO, PHCMLN, PHSLSM", new[] { "PHDOCO", "PHDCTO", "PHKCOO", "PHCMLN", "PHSLSM" }, isUnique: true, isPrimaryKey: true)
    };
}
