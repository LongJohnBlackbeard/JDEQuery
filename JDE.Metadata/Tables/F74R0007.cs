using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0007 - .
/// </summary>
public class F74R0007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FSK74LECO.
        /// </summary>
        public const string FSK74LECO = "FSK74LECO";

        /// <summary>
        /// FSMPID.
        /// </summary>
        public const string FSMPID = "FSMPID";

        /// <summary>
        /// FSK74LEDT.
        /// </summary>
        public const string FSK74LEDT = "FSK74LEDT";

        /// <summary>
        /// FSK74ISPL.
        /// </summary>
        public const string FSK74ISPL = "FSK74ISPL";

        /// <summary>
        /// FSVERS.
        /// </summary>
        public const string FSVERS = "FSVERS";

        /// <summary>
        /// FSR74ROLE.
        /// </summary>
        public const string FSR74ROLE = "FSR74ROLE";

        /// <summary>
        /// FSSEQ.
        /// </summary>
        public const string FSSEQ = "FSSEQ";

        /// <summary>
        /// FSAN8.
        /// </summary>
        public const string FSAN8 = "FSAN8";

        /// <summary>
        /// FSR74LAR.
        /// </summary>
        public const string FSR74LAR = "FSR74LAR";

        /// <summary>
        /// FSK74LMN.
        /// </summary>
        public const string FSK74LMN = "FSK74LMN";

        /// <summary>
        /// FSR74FST.
        /// </summary>
        public const string FSR74FST = "FSR74FST";

        /// <summary>
        /// FSUSER.
        /// </summary>
        public const string FSUSER = "FSUSER";

        /// <summary>
        /// FSPID.
        /// </summary>
        public const string FSPID = "FSPID";

        /// <summary>
        /// FSJOBN.
        /// </summary>
        public const string FSJOBN = "FSJOBN";

        /// <summary>
        /// FSUPMJ.
        /// </summary>
        public const string FSUPMJ = "FSUPMJ";

        /// <summary>
        /// FSUPMT.
        /// </summary>
        public const string FSUPMT = "FSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R0007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FSK74LECO", "FSK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("FSMPID", "FSMPID", JdeDataType.String, 20, true, true),
        new JdeField("FSK74LEDT", "FSK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("FSK74ISPL", "FSK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("FSVERS", "FSVERS", JdeDataType.String, 20, true, true),
        new JdeField("FSR74ROLE", "FSR74ROLE", JdeDataType.String, 20, true, true),
        new JdeField("FSSEQ", "FSSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("FSAN8", "FSAN8", JdeDataType.Numeric),
        new JdeField("FSR74LAR", "FSR74LAR", JdeDataType.String, 200),
        new JdeField("FSK74LMN", "FSK74LMN", JdeDataType.String, 200),
        new JdeField("FSR74FST", "FSR74FST", JdeDataType.String, 2),
        new JdeField("FSUSER", "FSUSER", JdeDataType.String, 20),
        new JdeField("FSPID", "FSPID", JdeDataType.String, 20),
        new JdeField("FSJOBN", "FSJOBN", JdeDataType.String, 20),
        new JdeField("FSUPMJ", "FSUPMJ", JdeDataType.Numeric),
        new JdeField("FSUPMT", "FSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0007_0", "Primary Key on FSK74LECO, FSMPID, FSK74LEDT, FSK74ISPL, FSVERS, FSR74ROLE, FSSEQ", new[] { "FSK74LECO", "FSMPID", "FSK74LEDT", "FSK74ISPL", "FSVERS", "FSR74ROLE", "FSSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
