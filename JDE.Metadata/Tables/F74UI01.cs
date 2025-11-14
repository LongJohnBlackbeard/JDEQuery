using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UI01 - .
/// </summary>
public class F74UI01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EUUKID.
        /// </summary>
        public const string EUUKID = "EUUKID";

        /// <summary>
        /// EUKCO.
        /// </summary>
        public const string EUKCO = "EUKCO";

        /// <summary>
        /// EUDCT.
        /// </summary>
        public const string EUDCT = "EUDCT";

        /// <summary>
        /// EUDOC.
        /// </summary>
        public const string EUDOC = "EUDOC";

        /// <summary>
        /// EUSEQ.
        /// </summary>
        public const string EUSEQ = "EUSEQ";

        /// <summary>
        /// EUKCOO.
        /// </summary>
        public const string EUKCOO = "EUKCOO";

        /// <summary>
        /// EUDOCO.
        /// </summary>
        public const string EUDOCO = "EUDOCO";

        /// <summary>
        /// EUDCTO.
        /// </summary>
        public const string EUDCTO = "EUDCTO";

        /// <summary>
        /// EULNID.
        /// </summary>
        public const string EULNID = "EULNID";

        /// <summary>
        /// EUSFXO.
        /// </summary>
        public const string EUSFXO = "EUSFXO";

        /// <summary>
        /// EUITM.
        /// </summary>
        public const string EUITM = "EUITM";

        /// <summary>
        /// EUCRCD.
        /// </summary>
        public const string EUCRCD = "EUCRCD";

        /// <summary>
        /// EUAEXP.
        /// </summary>
        public const string EUAEXP = "EUAEXP";

        /// <summary>
        /// EUTAX1.
        /// </summary>
        public const string EUTAX1 = "EUTAX1";

        /// <summary>
        /// EUSTAM.
        /// </summary>
        public const string EUSTAM = "EUSTAM";

        /// <summary>
        /// EUK74TVCC.
        /// </summary>
        public const string EUK74TVCC = "EUK74TVCC";

        /// <summary>
        /// EUTRAT.
        /// </summary>
        public const string EUTRAT = "EUTRAT";

        /// <summary>
        /// EUK74TE.
        /// </summary>
        public const string EUK74TE = "EUK74TE";

        /// <summary>
        /// EUK74EXRC.
        /// </summary>
        public const string EUK74EXRC = "EUK74EXRC";

        /// <summary>
        /// EUAPGM.
        /// </summary>
        public const string EUAPGM = "EUAPGM";

        /// <summary>
        /// EUUSER.
        /// </summary>
        public const string EUUSER = "EUUSER";

        /// <summary>
        /// EUPID.
        /// </summary>
        public const string EUPID = "EUPID";

        /// <summary>
        /// EUJOBN.
        /// </summary>
        public const string EUJOBN = "EUJOBN";

        /// <summary>
        /// EUUPMJ.
        /// </summary>
        public const string EUUPMJ = "EUUPMJ";

        /// <summary>
        /// EUUPMT.
        /// </summary>
        public const string EUUPMT = "EUUPMT";

        /// <summary>
        /// EUYFUTDT.
        /// </summary>
        public const string EUYFUTDT = "EUYFUTDT";

        /// <summary>
        /// EUFUT3.
        /// </summary>
        public const string EUFUT3 = "EUFUT3";

        /// <summary>
        /// EUFUTCH1.
        /// </summary>
        public const string EUFUTCH1 = "EUFUTCH1";

        /// <summary>
        /// EUX2.
        /// </summary>
        public const string EUX2 = "EUX2";

        /// <summary>
        /// EUFFU4.
        /// </summary>
        public const string EUFFU4 = "EUFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F74UI01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EUUKID", "EUUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EUKCO", "EUKCO", JdeDataType.String, 10, true, true),
        new JdeField("EUDCT", "EUDCT", JdeDataType.String, 4, true, true),
        new JdeField("EUDOC", "EUDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("EUSEQ", "EUSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("EUKCOO", "EUKCOO", JdeDataType.String, 10),
        new JdeField("EUDOCO", "EUDOCO", JdeDataType.Numeric),
        new JdeField("EUDCTO", "EUDCTO", JdeDataType.String, 4),
        new JdeField("EULNID", "EULNID", JdeDataType.Numeric),
        new JdeField("EUSFXO", "EUSFXO", JdeDataType.String, 6),
        new JdeField("EUITM", "EUITM", JdeDataType.Numeric),
        new JdeField("EUCRCD", "EUCRCD", JdeDataType.String, 6),
        new JdeField("EUAEXP", "EUAEXP", JdeDataType.Numeric),
        new JdeField("EUTAX1", "EUTAX1", JdeDataType.String, 2),
        new JdeField("EUSTAM", "EUSTAM", JdeDataType.Numeric),
        new JdeField("EUK74TVCC", "EUK74TVCC", JdeDataType.String, 20),
        new JdeField("EUTRAT", "EUTRAT", JdeDataType.Numeric),
        new JdeField("EUK74TE", "EUK74TE", JdeDataType.String, 2),
        new JdeField("EUK74EXRC", "EUK74EXRC", JdeDataType.String, 20),
        new JdeField("EUAPGM", "EUAPGM", JdeDataType.String, 20),
        new JdeField("EUUSER", "EUUSER", JdeDataType.String, 20, true, true),
        new JdeField("EUPID", "EUPID", JdeDataType.String, 20),
        new JdeField("EUJOBN", "EUJOBN", JdeDataType.String, 20),
        new JdeField("EUUPMJ", "EUUPMJ", JdeDataType.Numeric),
        new JdeField("EUUPMT", "EUUPMT", JdeDataType.Numeric),
        new JdeField("EUYFUTDT", "EUYFUTDT", JdeDataType.Numeric),
        new JdeField("EUFUT3", "EUFUT3", JdeDataType.String, 60),
        new JdeField("EUFUTCH1", "EUFUTCH1", JdeDataType.String, 2),
        new JdeField("EUX2", "EUX2", JdeDataType.String, 2),
        new JdeField("EUFFU4", "EUFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UI01_0", "Primary Key on EUDCT, EUKCO, EUDOC, EUSEQ, EUUSER, EUUKID", new[] { "EUDCT", "EUKCO", "EUDOC", "EUSEQ", "EUUSER", "EUUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
