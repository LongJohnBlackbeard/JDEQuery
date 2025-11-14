using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45522 - .
/// </summary>
public class F45522 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLDOCO.
        /// </summary>
        public const string PLDOCO = "PLDOCO";

        /// <summary>
        /// PLDCTO.
        /// </summary>
        public const string PLDCTO = "PLDCTO";

        /// <summary>
        /// PLITM.
        /// </summary>
        public const string PLITM = "PLITM";

        /// <summary>
        /// PLUORG.
        /// </summary>
        public const string PLUORG = "PLUORG";

        /// <summary>
        /// PLUOM.
        /// </summary>
        public const string PLUOM = "PLUOM";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";

        /// <summary>
        /// PLUPMT.
        /// </summary>
        public const string PLUPMT = "PLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F45522";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLDOCO", "PLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PLDCTO", "PLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PLITM", "PLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PLUORG", "PLUORG", JdeDataType.Numeric, null, true, true),
        new JdeField("PLUOM", "PLUOM", JdeDataType.String, 4, true, true),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric),
        new JdeField("PLUPMT", "PLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45522_0", "Primary Key on PLDOCO, PLDCTO, PLITM, PLUORG, PLUOM", new[] { "PLDOCO", "PLDCTO", "PLITM", "PLUORG", "PLUOM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F45522_3", "Index on PLDOCO, PLDCTO", new[] { "PLDOCO", "PLDCTO" })
    };
}
