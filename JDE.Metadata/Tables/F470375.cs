using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470375 - .
/// </summary>
public class F470375 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AKEDTY.
        /// </summary>
        public const string AKEDTY = "AKEDTY";

        /// <summary>
        /// AKEDSQ.
        /// </summary>
        public const string AKEDSQ = "AKEDSQ";

        /// <summary>
        /// AKEKCO.
        /// </summary>
        public const string AKEKCO = "AKEKCO";

        /// <summary>
        /// AKEDOC.
        /// </summary>
        public const string AKEDOC = "AKEDOC";

        /// <summary>
        /// AKEDCT.
        /// </summary>
        public const string AKEDCT = "AKEDCT";

        /// <summary>
        /// AKEDLN.
        /// </summary>
        public const string AKEDLN = "AKEDLN";

        /// <summary>
        /// AKEDST.
        /// </summary>
        public const string AKEDST = "AKEDST";

        /// <summary>
        /// AKEDFT.
        /// </summary>
        public const string AKEDFT = "AKEDFT";

        /// <summary>
        /// AKEDDT.
        /// </summary>
        public const string AKEDDT = "AKEDDT";

        /// <summary>
        /// AKEDER.
        /// </summary>
        public const string AKEDER = "AKEDER";

        /// <summary>
        /// AKEDDL.
        /// </summary>
        public const string AKEDDL = "AKEDDL";

        /// <summary>
        /// AKEDSP.
        /// </summary>
        public const string AKEDSP = "AKEDSP";

        /// <summary>
        /// AKEDBT.
        /// </summary>
        public const string AKEDBT = "AKEDBT";

        /// <summary>
        /// AKSTPC.
        /// </summary>
        public const string AKSTPC = "AKSTPC";

        /// <summary>
        /// AKANTY.
        /// </summary>
        public const string AKANTY = "AKANTY";

        /// <summary>
        /// AKLINS.
        /// </summary>
        public const string AKLINS = "AKLINS";

        /// <summary>
        /// AKCITM.
        /// </summary>
        public const string AKCITM = "AKCITM";

        /// <summary>
        /// AKPKCD.
        /// </summary>
        public const string AKPKCD = "AKPKCD";

        /// <summary>
        /// AKSTPK.
        /// </summary>
        public const string AKSTPK = "AKSTPK";

        /// <summary>
        /// AKTQTY.
        /// </summary>
        public const string AKTQTY = "AKTQTY";

        /// <summary>
        /// AKEQTY.
        /// </summary>
        public const string AKEQTY = "AKEQTY";

        /// <summary>
        /// AKUOM.
        /// </summary>
        public const string AKUOM = "AKUOM";

        /// <summary>
        /// AKEXCN.
        /// </summary>
        public const string AKEXCN = "AKEXCN";

        /// <summary>
        /// AKPKLVL.
        /// </summary>
        public const string AKPKLVL = "AKPKLVL";

        /// <summary>
        /// AKPKGRC.
        /// </summary>
        public const string AKPKGRC = "AKPKGRC";

        /// <summary>
        /// AKWEIT.
        /// </summary>
        public const string AKWEIT = "AKWEIT";

        /// <summary>
        /// AKGWEI.
        /// </summary>
        public const string AKGWEI = "AKGWEI";

        /// <summary>
        /// AKGRWT.
        /// </summary>
        public const string AKGRWT = "AKGRWT";

        /// <summary>
        /// AKUWUM.
        /// </summary>
        public const string AKUWUM = "AKUWUM";

        /// <summary>
        /// AKPKGTR.
        /// </summary>
        public const string AKPKGTR = "AKPKGTR";

        /// <summary>
        /// AKCHGREF.
        /// </summary>
        public const string AKCHGREF = "AKCHGREF";

        /// <summary>
        /// AKCHGAMT.
        /// </summary>
        public const string AKCHGAMT = "AKCHGAMT";

        /// <summary>
        /// AKCUMS.
        /// </summary>
        public const string AKCUMS = "AKCUMS";

        /// <summary>
        /// AKCUMSUOM.
        /// </summary>
        public const string AKCUMSUOM = "AKCUMSUOM";

        /// <summary>
        /// AKLDTAI.
        /// </summary>
        public const string AKLDTAI = "AKLDTAI";

        /// <summary>
        /// AKASID.
        /// </summary>
        public const string AKASID = "AKASID";

        /// <summary>
        /// AKCTSN.
        /// </summary>
        public const string AKCTSN = "AKCTSN";

        /// <summary>
        /// AKURCD.
        /// </summary>
        public const string AKURCD = "AKURCD";

        /// <summary>
        /// AKURDT.
        /// </summary>
        public const string AKURDT = "AKURDT";

        /// <summary>
        /// AKURAT.
        /// </summary>
        public const string AKURAT = "AKURAT";

        /// <summary>
        /// AKURAB.
        /// </summary>
        public const string AKURAB = "AKURAB";

        /// <summary>
        /// AKURRF.
        /// </summary>
        public const string AKURRF = "AKURRF";

        /// <summary>
        /// AKUSER.
        /// </summary>
        public const string AKUSER = "AKUSER";

        /// <summary>
        /// AKPID.
        /// </summary>
        public const string AKPID = "AKPID";

        /// <summary>
        /// AKJOBN.
        /// </summary>
        public const string AKJOBN = "AKJOBN";

        /// <summary>
        /// AKUPMJ.
        /// </summary>
        public const string AKUPMJ = "AKUPMJ";

        /// <summary>
        /// AKTDAY.
        /// </summary>
        public const string AKTDAY = "AKTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F470375";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AKEDTY", "AKEDTY", JdeDataType.String, 2),
        new JdeField("AKEDSQ", "AKEDSQ", JdeDataType.Numeric),
        new JdeField("AKEKCO", "AKEKCO", JdeDataType.String, 10, true, true),
        new JdeField("AKEDOC", "AKEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AKEDCT", "AKEDCT", JdeDataType.String, 4, true, true),
        new JdeField("AKEDLN", "AKEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("AKEDST", "AKEDST", JdeDataType.String, 12),
        new JdeField("AKEDFT", "AKEDFT", JdeDataType.String, 20),
        new JdeField("AKEDDT", "AKEDDT", JdeDataType.Numeric),
        new JdeField("AKEDER", "AKEDER", JdeDataType.String, 2),
        new JdeField("AKEDDL", "AKEDDL", JdeDataType.Numeric),
        new JdeField("AKEDSP", "AKEDSP", JdeDataType.String, 2),
        new JdeField("AKEDBT", "AKEDBT", JdeDataType.String, 30),
        new JdeField("AKSTPC", "AKSTPC", JdeDataType.String, 2, true, true),
        new JdeField("AKANTY", "AKANTY", JdeDataType.String, 2, true, true),
        new JdeField("AKLINS", "AKLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("AKCITM", "AKCITM", JdeDataType.String, 50),
        new JdeField("AKPKCD", "AKPKCD", JdeDataType.String, 10),
        new JdeField("AKSTPK", "AKSTPK", JdeDataType.Numeric),
        new JdeField("AKTQTY", "AKTQTY", JdeDataType.Numeric),
        new JdeField("AKEQTY", "AKEQTY", JdeDataType.String, 10, true, true),
        new JdeField("AKUOM", "AKUOM", JdeDataType.String, 4),
        new JdeField("AKEXCN", "AKEXCN", JdeDataType.String, 2),
        new JdeField("AKPKLVL", "AKPKLVL", JdeDataType.String, 6),
        new JdeField("AKPKGRC", "AKPKGRC", JdeDataType.String, 6),
        new JdeField("AKWEIT", "AKWEIT", JdeDataType.Numeric),
        new JdeField("AKGWEI", "AKGWEI", JdeDataType.Numeric),
        new JdeField("AKGRWT", "AKGRWT", JdeDataType.Numeric),
        new JdeField("AKUWUM", "AKUWUM", JdeDataType.String, 4),
        new JdeField("AKPKGTR", "AKPKGTR", JdeDataType.String, 6),
        new JdeField("AKCHGREF", "AKCHGREF", JdeDataType.String, 40, true, true),
        new JdeField("AKCHGAMT", "AKCHGAMT", JdeDataType.Numeric),
        new JdeField("AKCUMS", "AKCUMS", JdeDataType.Numeric),
        new JdeField("AKCUMSUOM", "AKCUMSUOM", JdeDataType.String, 6),
        new JdeField("AKLDTAI", "AKLDTAI", JdeDataType.String, 6),
        new JdeField("AKASID", "AKASID", JdeDataType.String, 50),
        new JdeField("AKCTSN", "AKCTSN", JdeDataType.String, 80),
        new JdeField("AKURCD", "AKURCD", JdeDataType.String, 4),
        new JdeField("AKURDT", "AKURDT", JdeDataType.Numeric),
        new JdeField("AKURAT", "AKURAT", JdeDataType.Numeric),
        new JdeField("AKURAB", "AKURAB", JdeDataType.Numeric),
        new JdeField("AKURRF", "AKURRF", JdeDataType.String, 30),
        new JdeField("AKUSER", "AKUSER", JdeDataType.String, 20),
        new JdeField("AKPID", "AKPID", JdeDataType.String, 20),
        new JdeField("AKJOBN", "AKJOBN", JdeDataType.String, 20),
        new JdeField("AKUPMJ", "AKUPMJ", JdeDataType.Numeric),
        new JdeField("AKTDAY", "AKTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470375_0", "Primary Key on AKEDOC, AKEDCT, AKEKCO, AKEDLN, AKSTPC, AKANTY, AKLINS, AKEQTY, AKCHGREF", new[] { "AKEDOC", "AKEDCT", "AKEKCO", "AKEDLN", "AKSTPC", "AKANTY", "AKLINS", "AKEQTY", "AKCHGREF" }, isUnique: true, isPrimaryKey: true)
    };
}
