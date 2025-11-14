using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R101T - .
/// </summary>
public class F74R101T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABR74LAR.
        /// </summary>
        public const string ABR74LAR = "ABR74LAR";

        /// <summary>
        /// ABK74LMN.
        /// </summary>
        public const string ABK74LMN = "ABK74LMN";

        /// <summary>
        /// ABK74ADL1.
        /// </summary>
        public const string ABK74ADL1 = "ABK74ADL1";

        /// <summary>
        /// ABK74ADL2.
        /// </summary>
        public const string ABK74ADL2 = "ABK74ADL2";

        /// <summary>
        /// ABK74ADL3.
        /// </summary>
        public const string ABK74ADL3 = "ABK74ADL3";

        /// <summary>
        /// ABK74ADL4.
        /// </summary>
        public const string ABK74ADL4 = "ABK74ADL4";

        /// <summary>
        /// ABR74KPP.
        /// </summary>
        public const string ABR74KPP = "ABR74KPP";

        /// <summary>
        /// ABR74OKDP.
        /// </summary>
        public const string ABR74OKDP = "ABR74OKDP";

        /// <summary>
        /// ABR74OKPO.
        /// </summary>
        public const string ABR74OKPO = "ABR74OKPO";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R101T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABR74LAR", "ABR74LAR", JdeDataType.String, 200),
        new JdeField("ABK74LMN", "ABK74LMN", JdeDataType.String, 200),
        new JdeField("ABK74ADL1", "ABK74ADL1", JdeDataType.String, 200),
        new JdeField("ABK74ADL2", "ABK74ADL2", JdeDataType.String, 200),
        new JdeField("ABK74ADL3", "ABK74ADL3", JdeDataType.String, 200),
        new JdeField("ABK74ADL4", "ABK74ADL4", JdeDataType.String, 200),
        new JdeField("ABR74KPP", "ABR74KPP", JdeDataType.String, 30),
        new JdeField("ABR74OKDP", "ABR74OKDP", JdeDataType.String, 14),
        new JdeField("ABR74OKPO", "ABR74OKPO", JdeDataType.String, 20),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R101T_0", "Primary Key on ABAN8", new[] { "ABAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
