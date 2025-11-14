using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E22 - .
/// </summary>
public class F43E22 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PSAN8V.
        /// </summary>
        public const string PSAN8V = "PSAN8V";

        /// <summary>
        /// PSCOMMETHD.
        /// </summary>
        public const string PSCOMMETHD = "PSCOMMETHD";

        /// <summary>
        /// PSAUTHURL.
        /// </summary>
        public const string PSAUTHURL = "PSAUTHURL";

        /// <summary>
        /// PSSIGNON.
        /// </summary>
        public const string PSSIGNON = "PSSIGNON";

        /// <summary>
        /// PSPASSWD.
        /// </summary>
        public const string PSPASSWD = "PSPASSWD";

        /// <summary>
        /// PSPOEXTR.
        /// </summary>
        public const string PSPOEXTR = "PSPOEXTR";

        /// <summary>
        /// PSAUTHMTD.
        /// </summary>
        public const string PSAUTHMTD = "PSAUTHMTD";

        /// <summary>
        /// PSXMLENCOD.
        /// </summary>
        public const string PSXMLENCOD = "PSXMLENCOD";

        /// <summary>
        /// PSALPH.
        /// </summary>
        public const string PSALPH = "PSALPH";

        /// <summary>
        /// PSVERS.
        /// </summary>
        public const string PSVERS = "PSVERS";

        /// <summary>
        /// PSXMLSCH.
        /// </summary>
        public const string PSXMLSCH = "PSXMLSCH";

        /// <summary>
        /// PSXMLSCH1.
        /// </summary>
        public const string PSXMLSCH1 = "PSXMLSCH1";

        /// <summary>
        /// PSXMLSCH2.
        /// </summary>
        public const string PSXMLSCH2 = "PSXMLSCH2";

        /// <summary>
        /// PSXMLVERS.
        /// </summary>
        public const string PSXMLVERS = "PSXMLVERS";

        /// <summary>
        /// PSXMLVERS1.
        /// </summary>
        public const string PSXMLVERS1 = "PSXMLVERS1";

        /// <summary>
        /// PSXMLVERS2.
        /// </summary>
        public const string PSXMLVERS2 = "PSXMLVERS2";

        /// <summary>
        /// PSFRMDMN.
        /// </summary>
        public const string PSFRMDMN = "PSFRMDMN";

        /// <summary>
        /// PSFRMIDEN.
        /// </summary>
        public const string PSFRMIDEN = "PSFRMIDEN";

        /// <summary>
        /// PSTODMN.
        /// </summary>
        public const string PSTODMN = "PSTODMN";

        /// <summary>
        /// PSTOIDEN.
        /// </summary>
        public const string PSTOIDEN = "PSTOIDEN";

        /// <summary>
        /// PSSENDDMN.
        /// </summary>
        public const string PSSENDDMN = "PSSENDDMN";

        /// <summary>
        /// PSSENDIDEN.
        /// </summary>
        public const string PSSENDIDEN = "PSSENDIDEN";

        /// <summary>
        /// PSMACTYPE.
        /// </summary>
        public const string PSMACTYPE = "PSMACTYPE";

        /// <summary>
        /// PSMACALGO.
        /// </summary>
        public const string PSMACALGO = "PSMACALGO";

        /// <summary>
        /// PSMACVALUE.
        /// </summary>
        public const string PSMACVALUE = "PSMACVALUE";

        /// <summary>
        /// PSCREATEDT.
        /// </summary>
        public const string PSCREATEDT = "PSCREATEDT";

        /// <summary>
        /// PSEXPIREDT.
        /// </summary>
        public const string PSEXPIREDT = "PSEXPIREDT";

        /// <summary>
        /// PSTYC.
        /// </summary>
        public const string PSTYC = "PSTYC";

        /// <summary>
        /// PSUSER.
        /// </summary>
        public const string PSUSER = "PSUSER";

        /// <summary>
        /// PSPID.
        /// </summary>
        public const string PSPID = "PSPID";

        /// <summary>
        /// PSJOBN.
        /// </summary>
        public const string PSJOBN = "PSJOBN";

        /// <summary>
        /// PSUPMT.
        /// </summary>
        public const string PSUPMT = "PSUPMT";

        /// <summary>
        /// PSUPMJ.
        /// </summary>
        public const string PSUPMJ = "PSUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43E22";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PSAN8V", "PSAN8V", JdeDataType.Numeric, null, true, true),
        new JdeField("PSCOMMETHD", "PSCOMMETHD", JdeDataType.String, 2, true, true),
        new JdeField("PSAUTHURL", "PSAUTHURL", JdeDataType.String),
        new JdeField("PSSIGNON", "PSSIGNON", JdeDataType.String, 60),
        new JdeField("PSPASSWD", "PSPASSWD", JdeDataType.String, 100),
        new JdeField("PSPOEXTR", "PSPOEXTR", JdeDataType.String, 2),
        new JdeField("PSAUTHMTD", "PSAUTHMTD", JdeDataType.String, 2),
        new JdeField("PSXMLENCOD", "PSXMLENCOD", JdeDataType.String, 2),
        new JdeField("PSALPH", "PSALPH", JdeDataType.String, 80),
        new JdeField("PSVERS", "PSVERS", JdeDataType.String, 20),
        new JdeField("PSXMLSCH", "PSXMLSCH", JdeDataType.String, 60),
        new JdeField("PSXMLSCH1", "PSXMLSCH1", JdeDataType.String, 60),
        new JdeField("PSXMLSCH2", "PSXMLSCH2", JdeDataType.String, 60),
        new JdeField("PSXMLVERS", "PSXMLVERS", JdeDataType.String, 20),
        new JdeField("PSXMLVERS1", "PSXMLVERS1", JdeDataType.String, 20),
        new JdeField("PSXMLVERS2", "PSXMLVERS2", JdeDataType.String, 20),
        new JdeField("PSFRMDMN", "PSFRMDMN", JdeDataType.String, 62),
        new JdeField("PSFRMIDEN", "PSFRMIDEN", JdeDataType.String, 62),
        new JdeField("PSTODMN", "PSTODMN", JdeDataType.String, 62),
        new JdeField("PSTOIDEN", "PSTOIDEN", JdeDataType.String, 62),
        new JdeField("PSSENDDMN", "PSSENDDMN", JdeDataType.String, 62),
        new JdeField("PSSENDIDEN", "PSSENDIDEN", JdeDataType.String, 62),
        new JdeField("PSMACTYPE", "PSMACTYPE", JdeDataType.String, 62),
        new JdeField("PSMACALGO", "PSMACALGO", JdeDataType.String, 62),
        new JdeField("PSMACVALUE", "PSMACVALUE", JdeDataType.String, 602),
        new JdeField("PSCREATEDT", "PSCREATEDT", JdeDataType.String, 60),
        new JdeField("PSEXPIREDT", "PSEXPIREDT", JdeDataType.String, 60),
        new JdeField("PSTYC", "PSTYC", JdeDataType.String, 2),
        new JdeField("PSUSER", "PSUSER", JdeDataType.String, 20),
        new JdeField("PSPID", "PSPID", JdeDataType.String, 20),
        new JdeField("PSJOBN", "PSJOBN", JdeDataType.String, 20),
        new JdeField("PSUPMT", "PSUPMT", JdeDataType.Numeric),
        new JdeField("PSUPMJ", "PSUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E22_0", "Primary Key on PSAN8V, PSCOMMETHD", new[] { "PSAN8V", "PSCOMMETHD" }, isUnique: true, isPrimaryKey: true)
    };
}
