using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F13411 - .
/// </summary>
public class F13411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RXNUMB.
        /// </summary>
        public const string RXNUMB = "RXNUMB";

        /// <summary>
        /// RXSRVT.
        /// </summary>
        public const string RXSRVT = "RXSRVT";

        /// <summary>
        /// RXTYPF.
        /// </summary>
        public const string RXTYPF = "RXTYPF";

        /// <summary>
        /// RXFQT.
        /// </summary>
        public const string RXFQT = "RXFQT";

        /// <summary>
        /// RXTDT.
        /// </summary>
        public const string RXTDT = "RXTDT";

        /// <summary>
        /// RXHRSO.
        /// </summary>
        public const string RXHRSO = "RXHRSO";

        /// <summary>
        /// RXAMLC.
        /// </summary>
        public const string RXAMLC = "RXAMLC";

        /// <summary>
        /// RXAMMC.
        /// </summary>
        public const string RXAMMC = "RXAMMC";

        /// <summary>
        /// RXMCU.
        /// </summary>
        public const string RXMCU = "RXMCU";

        /// <summary>
        /// RXESDN.
        /// </summary>
        public const string RXESDN = "RXESDN";

        /// <summary>
        /// RXDOCO.
        /// </summary>
        public const string RXDOCO = "RXDOCO";

        /// <summary>
        /// RXMMCU.
        /// </summary>
        public const string RXMMCU = "RXMMCU";

        /// <summary>
        /// RXDCTO.
        /// </summary>
        public const string RXDCTO = "RXDCTO";

        /// <summary>
        /// RXTYPS.
        /// </summary>
        public const string RXTYPS = "RXTYPS";

        /// <summary>
        /// RXPRTS.
        /// </summary>
        public const string RXPRTS = "RXPRTS";

        /// <summary>
        /// RXSRST.
        /// </summary>
        public const string RXSRST = "RXSRST";

        /// <summary>
        /// RXDL01.
        /// </summary>
        public const string RXDL01 = "RXDL01";

        /// <summary>
        /// RXWR01.
        /// </summary>
        public const string RXWR01 = "RXWR01";

        /// <summary>
        /// RXWR02.
        /// </summary>
        public const string RXWR02 = "RXWR02";

        /// <summary>
        /// RXWR03.
        /// </summary>
        public const string RXWR03 = "RXWR03";

        /// <summary>
        /// RXWR04.
        /// </summary>
        public const string RXWR04 = "RXWR04";

        /// <summary>
        /// RXWR05.
        /// </summary>
        public const string RXWR05 = "RXWR05";

        /// <summary>
        /// RXWR06.
        /// </summary>
        public const string RXWR06 = "RXWR06";

        /// <summary>
        /// RXWR07.
        /// </summary>
        public const string RXWR07 = "RXWR07";

        /// <summary>
        /// RXWR08.
        /// </summary>
        public const string RXWR08 = "RXWR08";

        /// <summary>
        /// RXWR09.
        /// </summary>
        public const string RXWR09 = "RXWR09";

        /// <summary>
        /// RXWR10.
        /// </summary>
        public const string RXWR10 = "RXWR10";

        /// <summary>
        /// RXANSA.
        /// </summary>
        public const string RXANSA = "RXANSA";

        /// <summary>
        /// RXANPA.
        /// </summary>
        public const string RXANPA = "RXANPA";

        /// <summary>
        /// RXAN8.
        /// </summary>
        public const string RXAN8 = "RXAN8";

        /// <summary>
        /// RXSAID.
        /// </summary>
        public const string RXSAID = "RXSAID";

        /// <summary>
        /// RXMCUW.
        /// </summary>
        public const string RXMCUW = "RXMCUW";

        /// <summary>
        /// RXMCULT.
        /// </summary>
        public const string RXMCULT = "RXMCULT";

        /// <summary>
        /// RXWSCHF.
        /// </summary>
        public const string RXWSCHF = "RXWSCHF";

        /// <summary>
        /// RXWONA.
        /// </summary>
        public const string RXWONA = "RXWONA";

        /// <summary>
        /// RXITM.
        /// </summary>
        public const string RXITM = "RXITM";

        /// <summary>
        /// RXTBM.
        /// </summary>
        public const string RXTBM = "RXTBM";

        /// <summary>
        /// RXTRT.
        /// </summary>
        public const string RXTRT = "RXTRT";

        /// <summary>
        /// RXUSER.
        /// </summary>
        public const string RXUSER = "RXUSER";

        /// <summary>
        /// RXPID.
        /// </summary>
        public const string RXPID = "RXPID";

        /// <summary>
        /// RXMKEY.
        /// </summary>
        public const string RXMKEY = "RXMKEY";

        /// <summary>
        /// RXUPMJ.
        /// </summary>
        public const string RXUPMJ = "RXUPMJ";

        /// <summary>
        /// RXUPMT.
        /// </summary>
        public const string RXUPMT = "RXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F13411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RXNUMB", "RXNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("RXSRVT", "RXSRVT", JdeDataType.String, 16, true, true),
        new JdeField("RXTYPF", "RXTYPF", JdeDataType.String, 4, true, true),
        new JdeField("RXFQT", "RXFQT", JdeDataType.Numeric),
        new JdeField("RXTDT", "RXTDT", JdeDataType.Numeric, null, true, true),
        new JdeField("RXHRSO", "RXHRSO", JdeDataType.Numeric),
        new JdeField("RXAMLC", "RXAMLC", JdeDataType.Numeric),
        new JdeField("RXAMMC", "RXAMMC", JdeDataType.Numeric),
        new JdeField("RXMCU", "RXMCU", JdeDataType.String, 24),
        new JdeField("RXESDN", "RXESDN", JdeDataType.Numeric),
        new JdeField("RXDOCO", "RXDOCO", JdeDataType.Numeric),
        new JdeField("RXMMCU", "RXMMCU", JdeDataType.String, 24),
        new JdeField("RXDCTO", "RXDCTO", JdeDataType.String, 4),
        new JdeField("RXTYPS", "RXTYPS", JdeDataType.String, 2),
        new JdeField("RXPRTS", "RXPRTS", JdeDataType.String, 2),
        new JdeField("RXSRST", "RXSRST", JdeDataType.String, 4),
        new JdeField("RXDL01", "RXDL01", JdeDataType.String, 60),
        new JdeField("RXWR01", "RXWR01", JdeDataType.String, 8),
        new JdeField("RXWR02", "RXWR02", JdeDataType.String, 6),
        new JdeField("RXWR03", "RXWR03", JdeDataType.String, 6),
        new JdeField("RXWR04", "RXWR04", JdeDataType.String, 6),
        new JdeField("RXWR05", "RXWR05", JdeDataType.String, 6),
        new JdeField("RXWR06", "RXWR06", JdeDataType.String, 6),
        new JdeField("RXWR07", "RXWR07", JdeDataType.String, 6),
        new JdeField("RXWR08", "RXWR08", JdeDataType.String, 6),
        new JdeField("RXWR09", "RXWR09", JdeDataType.String, 6),
        new JdeField("RXWR10", "RXWR10", JdeDataType.String, 6),
        new JdeField("RXANSA", "RXANSA", JdeDataType.Numeric),
        new JdeField("RXANPA", "RXANPA", JdeDataType.Numeric),
        new JdeField("RXAN8", "RXAN8", JdeDataType.Numeric),
        new JdeField("RXSAID", "RXSAID", JdeDataType.Numeric),
        new JdeField("RXMCUW", "RXMCUW", JdeDataType.String, 24),
        new JdeField("RXMCULT", "RXMCULT", JdeDataType.String, 24),
        new JdeField("RXWSCHF", "RXWSCHF", JdeDataType.String, 2),
        new JdeField("RXWONA", "RXWONA", JdeDataType.Numeric),
        new JdeField("RXITM", "RXITM", JdeDataType.Numeric),
        new JdeField("RXTBM", "RXTBM", JdeDataType.String, 6),
        new JdeField("RXTRT", "RXTRT", JdeDataType.String, 6),
        new JdeField("RXUSER", "RXUSER", JdeDataType.String, 20),
        new JdeField("RXPID", "RXPID", JdeDataType.String, 20),
        new JdeField("RXMKEY", "RXMKEY", JdeDataType.String, 30),
        new JdeField("RXUPMJ", "RXUPMJ", JdeDataType.Numeric),
        new JdeField("RXUPMT", "RXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F13411_0", "Primary Key on RXNUMB, RXSRVT, RXTYPF, RXTDT", new[] { "RXNUMB", "RXSRVT", "RXTYPF", "RXTDT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F13411_2", "Index on RXTYPF, RXTDT, RXANSA, RXANPA, RXWONA, RXWSCHF", new[] { "RXTYPF", "RXTDT", "RXANSA", "RXANPA", "RXWONA", "RXWSCHF" })
    };
}
