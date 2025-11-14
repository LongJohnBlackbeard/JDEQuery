using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4062 - .
/// </summary>
public class F74U4062 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AMU74VER.
        /// </summary>
        public const string AMU74VER = "AMU74VER";

        /// <summary>
        /// AMU74ICR.
        /// </summary>
        public const string AMU74ICR = "AMU74ICR";

        /// <summary>
        /// AMU74LAN8.
        /// </summary>
        public const string AMU74LAN8 = "AMU74LAN8";

        /// <summary>
        /// AMU74DES.
        /// </summary>
        public const string AMU74DES = "AMU74DES";

        /// <summary>
        /// AMU74UTR.
        /// </summary>
        public const string AMU74UTR = "AMU74UTR";

        /// <summary>
        /// AMU74NATI.
        /// </summary>
        public const string AMU74NATI = "AMU74NATI";

        /// <summary>
        /// AMADD1.
        /// </summary>
        public const string AMADD1 = "AMADD1";

        /// <summary>
        /// AMADD2.
        /// </summary>
        public const string AMADD2 = "AMADD2";

        /// <summary>
        /// AMADD3.
        /// </summary>
        public const string AMADD3 = "AMADD3";

        /// <summary>
        /// AMADD4.
        /// </summary>
        public const string AMADD4 = "AMADD4";

        /// <summary>
        /// AMCTR.
        /// </summary>
        public const string AMCTR = "AMCTR";

        /// <summary>
        /// AMU74SCSU.
        /// </summary>
        public const string AMU74SCSU = "AMU74SCSU";

        /// <summary>
        /// AMU74SC1F.
        /// </summary>
        public const string AMU74SC1F = "AMU74SC1F";

        /// <summary>
        /// AMU74SC2F.
        /// </summary>
        public const string AMU74SC2F = "AMU74SC2F";

        /// <summary>
        /// AMU74SCMF.
        /// </summary>
        public const string AMU74SCMF = "AMU74SCMF";

        /// <summary>
        /// AMUKCRN.
        /// </summary>
        public const string AMUKCRN = "AMUKCRN";

        /// <summary>
        /// AMUKNTIN.
        /// </summary>
        public const string AMUKNTIN = "AMUKNTIN";

        /// <summary>
        /// AMU74SCVN.
        /// </summary>
        public const string AMU74SCVN = "AMU74SCVN";

        /// <summary>
        /// AMU74TOPM.
        /// </summary>
        public const string AMU74TOPM = "AMU74TOPM";

        /// <summary>
        /// AMU74TOCM.
        /// </summary>
        public const string AMU74TOCM = "AMU74TOCM";

        /// <summary>
        /// AMU74TOAD.
        /// </summary>
        public const string AMU74TOAD = "AMU74TOAD";

        /// <summary>
        /// AMUSER.
        /// </summary>
        public const string AMUSER = "AMUSER";

        /// <summary>
        /// AMPID.
        /// </summary>
        public const string AMPID = "AMPID";

        /// <summary>
        /// AMUPMJ.
        /// </summary>
        public const string AMUPMJ = "AMUPMJ";

        /// <summary>
        /// AMUPMT.
        /// </summary>
        public const string AMUPMT = "AMUPMT";

        /// <summary>
        /// AMJOBN.
        /// </summary>
        public const string AMJOBN = "AMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U4062";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AMU74VER", "AMU74VER", JdeDataType.String, 28, true, true),
        new JdeField("AMU74ICR", "AMU74ICR", JdeDataType.String, 28, true, true),
        new JdeField("AMU74LAN8", "AMU74LAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AMU74DES", "AMU74DES", JdeDataType.String, 60),
        new JdeField("AMU74UTR", "AMU74UTR", JdeDataType.Numeric),
        new JdeField("AMU74NATI", "AMU74NATI", JdeDataType.String, 2),
        new JdeField("AMADD1", "AMADD1", JdeDataType.String, 80),
        new JdeField("AMADD2", "AMADD2", JdeDataType.String, 80),
        new JdeField("AMADD3", "AMADD3", JdeDataType.String, 80),
        new JdeField("AMADD4", "AMADD4", JdeDataType.String, 80),
        new JdeField("AMCTR", "AMCTR", JdeDataType.String, 6),
        new JdeField("AMU74SCSU", "AMU74SCSU", JdeDataType.String, 70),
        new JdeField("AMU74SC1F", "AMU74SC1F", JdeDataType.String, 70),
        new JdeField("AMU74SC2F", "AMU74SC2F", JdeDataType.String, 70),
        new JdeField("AMU74SCMF", "AMU74SCMF", JdeDataType.String, 2),
        new JdeField("AMUKCRN", "AMUKCRN", JdeDataType.String, 16),
        new JdeField("AMUKNTIN", "AMUKNTIN", JdeDataType.String, 18),
        new JdeField("AMU74SCVN", "AMU74SCVN", JdeDataType.String, 26),
        new JdeField("AMU74TOPM", "AMU74TOPM", JdeDataType.Numeric),
        new JdeField("AMU74TOCM", "AMU74TOCM", JdeDataType.Numeric),
        new JdeField("AMU74TOAD", "AMU74TOAD", JdeDataType.Numeric),
        new JdeField("AMUSER", "AMUSER", JdeDataType.String, 20),
        new JdeField("AMPID", "AMPID", JdeDataType.String, 20),
        new JdeField("AMUPMJ", "AMUPMJ", JdeDataType.Numeric),
        new JdeField("AMUPMT", "AMUPMT", JdeDataType.Numeric),
        new JdeField("AMJOBN", "AMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4062_0", "Primary Key on AMU74VER, AMU74ICR, AMU74LAN8", new[] { "AMU74VER", "AMU74ICR", "AMU74LAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U4062_2", "Index on AMU74VER", new[] { "AMU74VER" })
    };
}
