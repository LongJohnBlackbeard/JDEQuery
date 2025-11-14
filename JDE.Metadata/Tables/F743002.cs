using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F743002 - .
/// </summary>
public class F743002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SM74MDT.
        /// </summary>
        public const string SM74MDT = "SM74MDT";

        /// <summary>
        /// SM74MDTID.
        /// </summary>
        public const string SM74MDTID = "SM74MDTID";

        /// <summary>
        /// SM74MDD.
        /// </summary>
        public const string SM74MDD = "SM74MDD";

        /// <summary>
        /// SM74MDCD.
        /// </summary>
        public const string SM74MDCD = "SM74MDCD";

        /// <summary>
        /// SM74MSTY.
        /// </summary>
        public const string SM74MSTY = "SM74MSTY";

        /// <summary>
        /// SM74MSTS.
        /// </summary>
        public const string SM74MSTS = "SM74MSTS";

        /// <summary>
        /// SM74MAD.
        /// </summary>
        public const string SM74MAD = "SM74MAD";

        /// <summary>
        /// SM74MVER.
        /// </summary>
        public const string SM74MVER = "SM74MVER";

        /// <summary>
        /// SM74LCD.
        /// </summary>
        public const string SM74LCD = "SM74LCD";

        /// <summary>
        /// SM74MTC.
        /// </summary>
        public const string SM74MTC = "SM74MTC";

        /// <summary>
        /// SM74DBTID.
        /// </summary>
        public const string SM74DBTID = "SM74DBTID";

        /// <summary>
        /// SM74AIDD.
        /// </summary>
        public const string SM74AIDD = "SM74AIDD";

        /// <summary>
        /// SM74AN8D.
        /// </summary>
        public const string SM74AN8D = "SM74AN8D";

        /// <summary>
        /// SM74UAND.
        /// </summary>
        public const string SM74UAND = "SM74UAND";

        /// <summary>
        /// SM74AN8C.
        /// </summary>
        public const string SM74AN8C = "SM74AN8C";

        /// <summary>
        /// SM74AIDC.
        /// </summary>
        public const string SM74AIDC = "SM74AIDC";

        /// <summary>
        /// SM74UANC.
        /// </summary>
        public const string SM74UANC = "SM74UANC";

        /// <summary>
        /// SM74AN8UD.
        /// </summary>
        public const string SM74AN8UD = "SM74AN8UD";

        /// <summary>
        /// SM74CDTID.
        /// </summary>
        public const string SM74CDTID = "SM74CDTID";

        /// <summary>
        /// SM74CCC.
        /// </summary>
        public const string SM74CCC = "SM74CCC";

        /// <summary>
        /// SM74CDV.
        /// </summary>
        public const string SM74CDV = "SM74CDV";

        /// <summary>
        /// SM74CBC.
        /// </summary>
        public const string SM74CBC = "SM74CBC";

        /// <summary>
        /// SM74CNI.
        /// </summary>
        public const string SM74CNI = "SM74CNI";

        /// <summary>
        /// SM74MAL.
        /// </summary>
        public const string SM74MAL = "SM74MAL";

        /// <summary>
        /// SM74MTL.
        /// </summary>
        public const string SM74MTL = "SM74MTL";

        /// <summary>
        /// SM74OMDT.
        /// </summary>
        public const string SM74OMDT = "SM74OMDT";

        /// <summary>
        /// SM74OCDT.
        /// </summary>
        public const string SM74OCDT = "SM74OCDT";

        /// <summary>
        /// SM74OCDN.
        /// </summary>
        public const string SM74OCDN = "SM74OCDN";

        /// <summary>
        /// SM74ODBI.
        /// </summary>
        public const string SM74ODBI = "SM74ODBI";

        /// <summary>
        /// SM74OUAD.
        /// </summary>
        public const string SM74OUAD = "SM74OUAD";

        /// <summary>
        /// SM74ODBB.
        /// </summary>
        public const string SM74ODBB = "SM74ODBB";

        /// <summary>
        /// SM74ODIB.
        /// </summary>
        public const string SM74ODIB = "SM74ODIB";

        /// <summary>
        /// SMUSER.
        /// </summary>
        public const string SMUSER = "SMUSER";

        /// <summary>
        /// SMPID.
        /// </summary>
        public const string SMPID = "SMPID";

        /// <summary>
        /// SMJOBN.
        /// </summary>
        public const string SMJOBN = "SMJOBN";

        /// <summary>
        /// SMUPMT.
        /// </summary>
        public const string SMUPMT = "SMUPMT";

        /// <summary>
        /// SMUPDJ.
        /// </summary>
        public const string SMUPDJ = "SMUPDJ";

        /// <summary>
        /// SM74LINS.
        /// </summary>
        public const string SM74LINS = "SM74LINS";
    }

    /// <inheritdoc />
    public override string TableName => "F743002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SM74MDT", "SM74MDT", JdeDataType.Numeric, null, true, true),
        new JdeField("SM74MDTID", "SM74MDTID", JdeDataType.String, 70),
        new JdeField("SM74MDD", "SM74MDD", JdeDataType.Numeric),
        new JdeField("SM74MDCD", "SM74MDCD", JdeDataType.Numeric),
        new JdeField("SM74MSTY", "SM74MSTY", JdeDataType.String, 8),
        new JdeField("SM74MSTS", "SM74MSTS", JdeDataType.String, 2),
        new JdeField("SM74MAD", "SM74MAD", JdeDataType.Numeric),
        new JdeField("SM74MVER", "SM74MVER", JdeDataType.Numeric),
        new JdeField("SM74LCD", "SM74LCD", JdeDataType.Numeric),
        new JdeField("SM74MTC", "SM74MTC", JdeDataType.Numeric),
        new JdeField("SM74DBTID", "SM74DBTID", JdeDataType.String, 40),
        new JdeField("SM74AIDD", "SM74AIDD", JdeDataType.String, 16),
        new JdeField("SM74AN8D", "SM74AN8D", JdeDataType.Numeric),
        new JdeField("SM74UAND", "SM74UAND", JdeDataType.Numeric),
        new JdeField("SM74AN8C", "SM74AN8C", JdeDataType.Numeric),
        new JdeField("SM74AIDC", "SM74AIDC", JdeDataType.String, 16),
        new JdeField("SM74UANC", "SM74UANC", JdeDataType.Numeric),
        new JdeField("SM74AN8UD", "SM74AN8UD", JdeDataType.Numeric),
        new JdeField("SM74CDTID", "SM74CDTID", JdeDataType.String, 70),
        new JdeField("SM74CCC", "SM74CCC", JdeDataType.String, 4),
        new JdeField("SM74CDV", "SM74CDV", JdeDataType.String, 4),
        new JdeField("SM74CBC", "SM74CBC", JdeDataType.String, 6),
        new JdeField("SM74CNI", "SM74CNI", JdeDataType.String, 56),
        new JdeField("SM74MAL", "SM74MAL", JdeDataType.Numeric),
        new JdeField("SM74MTL", "SM74MTL", JdeDataType.Numeric),
        new JdeField("SM74OMDT", "SM74OMDT", JdeDataType.String, 70),
        new JdeField("SM74OCDT", "SM74OCDT", JdeDataType.String, 70),
        new JdeField("SM74OCDN", "SM74OCDN", JdeDataType.String, 80),
        new JdeField("SM74ODBI", "SM74ODBI", JdeDataType.String, 16),
        new JdeField("SM74OUAD", "SM74OUAD", JdeDataType.Numeric),
        new JdeField("SM74ODBB", "SM74ODBB", JdeDataType.String, 30),
        new JdeField("SM74ODIB", "SM74ODIB", JdeDataType.String, 68),
        new JdeField("SMUSER", "SMUSER", JdeDataType.String, 20),
        new JdeField("SMPID", "SMPID", JdeDataType.String, 20),
        new JdeField("SMJOBN", "SMJOBN", JdeDataType.String, 20),
        new JdeField("SMUPMT", "SMUPMT", JdeDataType.Numeric),
        new JdeField("SMUPDJ", "SMUPDJ", JdeDataType.Numeric),
        new JdeField("SM74LINS", "SM74LINS", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F743002_0", "Primary Key on SM74MDT", new[] { "SM74MDT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F743002_2", "Index on SM74MDTID, SM74CDTID", new[] { "SM74MDTID", "SM74CDTID" })
    };
}
