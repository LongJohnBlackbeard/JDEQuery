using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76111B - .
/// </summary>
public class F76111B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QUBRANFK.
        /// </summary>
        public const string QUBRANFK = "QUBRANFK";

        /// <summary>
        /// QULNID.
        /// </summary>
        public const string QULNID = "QULNID";

        /// <summary>
        /// QUBRNOP.
        /// </summary>
        public const string QUBRNOP = "QUBRNOP";

        /// <summary>
        /// QUBSOP.
        /// </summary>
        public const string QUBSOP = "QUBSOP";

        /// <summary>
        /// QUITM.
        /// </summary>
        public const string QUITM = "QUITM";

        /// <summary>
        /// QULITM.
        /// </summary>
        public const string QULITM = "QULITM";

        /// <summary>
        /// QUAITM.
        /// </summary>
        public const string QUAITM = "QUAITM";

        /// <summary>
        /// QUDSC1.
        /// </summary>
        public const string QUDSC1 = "QUDSC1";

        /// <summary>
        /// QUDSC2.
        /// </summary>
        public const string QUDSC2 = "QUDSC2";

        /// <summary>
        /// QUUORG.
        /// </summary>
        public const string QUUORG = "QUUORG";

        /// <summary>
        /// QUUOM.
        /// </summary>
        public const string QUUOM = "QUUOM";

        /// <summary>
        /// QUPRIC.
        /// </summary>
        public const string QUPRIC = "QUPRIC";

        /// <summary>
        /// QUUPRC.
        /// </summary>
        public const string QUUPRC = "QUUPRC";

        /// <summary>
        /// QUAEXP.
        /// </summary>
        public const string QUAEXP = "QUAEXP";

        /// <summary>
        /// QUBCLF.
        /// </summary>
        public const string QUBCLF = "QUBCLF";

        /// <summary>
        /// QUBRAAIP.
        /// </summary>
        public const string QUBRAAIP = "QUBRAAIP";

        /// <summary>
        /// QUBBCL.
        /// </summary>
        public const string QUBBCL = "QUBBCL";

        /// <summary>
        /// QUBBIR.
        /// </summary>
        public const string QUBBIR = "QUBBIR";

        /// <summary>
        /// QUBRAAIC.
        /// </summary>
        public const string QUBRAAIC = "QUBRAAIC";

        /// <summary>
        /// QUBRAVCI.
        /// </summary>
        public const string QUBRAVCI = "QUBRAVCI";

        /// <summary>
        /// QUBREP.
        /// </summary>
        public const string QUBREP = "QUBREP";

        /// <summary>
        /// QUBBIS.
        /// </summary>
        public const string QUBBIS = "QUBBIS";

        /// <summary>
        /// QUBVIS.
        /// </summary>
        public const string QUBVIS = "QUBVIS";

        /// <summary>
        /// QUBSTT.
        /// </summary>
        public const string QUBSTT = "QUBSTT";

        /// <summary>
        /// QUBST1.
        /// </summary>
        public const string QUBST1 = "QUBST1";

        /// <summary>
        /// QUBDIZ.
        /// </summary>
        public const string QUBDIZ = "QUBDIZ";

        /// <summary>
        /// QUBDES.
        /// </summary>
        public const string QUBDES = "QUBDES";

        /// <summary>
        /// QUBRATDF.
        /// </summary>
        public const string QUBRATDF = "QUBRATDF";

        /// <summary>
        /// QUBBTP.
        /// </summary>
        public const string QUBBTP = "QUBBTP";

        /// <summary>
        /// QUBIPI.
        /// </summary>
        public const string QUBIPI = "QUBIPI";

        /// <summary>
        /// QUBBCS.
        /// </summary>
        public const string QUBBCS = "QUBBCS";

        /// <summary>
        /// QUBISS.
        /// </summary>
        public const string QUBISS = "QUBISS";

        /// <summary>
        /// QUBRAAIS.
        /// </summary>
        public const string QUBRAAIS = "QUBRAAIS";

        /// <summary>
        /// QUBRAITC.
        /// </summary>
        public const string QUBRAITC = "QUBRAITC";

        /// <summary>
        /// QUBRABIP.
        /// </summary>
        public const string QUBRABIP = "QUBRABIP";

        /// <summary>
        /// QUBRAITP.
        /// </summary>
        public const string QUBRAITP = "QUBRAITP";

        /// <summary>
        /// QUBRAPBR.
        /// </summary>
        public const string QUBRAPBR = "QUBRAPBR";

        /// <summary>
        /// QUBRAUDP.
        /// </summary>
        public const string QUBRAUDP = "QUBRAUDP";

        /// <summary>
        /// QUTRTY.
        /// </summary>
        public const string QUTRTY = "QUTRTY";

        /// <summary>
        /// QUUSER.
        /// </summary>
        public const string QUUSER = "QUUSER";

        /// <summary>
        /// QUPID.
        /// </summary>
        public const string QUPID = "QUPID";

        /// <summary>
        /// QUJOBN.
        /// </summary>
        public const string QUJOBN = "QUJOBN";

        /// <summary>
        /// QUUPMJ.
        /// </summary>
        public const string QUUPMJ = "QUUPMJ";

        /// <summary>
        /// QUUPMT.
        /// </summary>
        public const string QUUPMT = "QUUPMT";

        /// <summary>
        /// QUTDAY.
        /// </summary>
        public const string QUTDAY = "QUTDAY";

        /// <summary>
        /// QUBRS1.
        /// </summary>
        public const string QUBRS1 = "QUBRS1";

        /// <summary>
        /// QUBRS2.
        /// </summary>
        public const string QUBRS2 = "QUBRS2";

        /// <summary>
        /// QUBRS3.
        /// </summary>
        public const string QUBRS3 = "QUBRS3";

        /// <summary>
        /// QUBRN1.
        /// </summary>
        public const string QUBRN1 = "QUBRN1";

        /// <summary>
        /// QUBRN2.
        /// </summary>
        public const string QUBRN2 = "QUBRN2";

        /// <summary>
        /// QUBRN3.
        /// </summary>
        public const string QUBRN3 = "QUBRN3";

        /// <summary>
        /// QUBRN4.
        /// </summary>
        public const string QUBRN4 = "QUBRN4";

        /// <summary>
        /// QUBRN5.
        /// </summary>
        public const string QUBRN5 = "QUBRN5";

        /// <summary>
        /// QUBRN6.
        /// </summary>
        public const string QUBRN6 = "QUBRN6";

        /// <summary>
        /// QUBRN7.
        /// </summary>
        public const string QUBRN7 = "QUBRN7";

        /// <summary>
        /// QUBRN8.
        /// </summary>
        public const string QUBRN8 = "QUBRN8";

        /// <summary>
        /// QUBRN9.
        /// </summary>
        public const string QUBRN9 = "QUBRN9";

        /// <summary>
        /// QUBRJD1.
        /// </summary>
        public const string QUBRJD1 = "QUBRJD1";

        /// <summary>
        /// QUBRJD2.
        /// </summary>
        public const string QUBRJD2 = "QUBRJD2";
    }

    /// <inheritdoc />
    public override string TableName => "F76111B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QUBRANFK", "QUBRANFK", JdeDataType.Numeric, null, true, true),
        new JdeField("QULNID", "QULNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QUBRNOP", "QUBRNOP", JdeDataType.String, 10),
        new JdeField("QUBSOP", "QUBSOP", JdeDataType.String, 4),
        new JdeField("QUITM", "QUITM", JdeDataType.Numeric),
        new JdeField("QULITM", "QULITM", JdeDataType.String, 50),
        new JdeField("QUAITM", "QUAITM", JdeDataType.String, 50),
        new JdeField("QUDSC1", "QUDSC1", JdeDataType.String, 60),
        new JdeField("QUDSC2", "QUDSC2", JdeDataType.String, 60),
        new JdeField("QUUORG", "QUUORG", JdeDataType.Numeric),
        new JdeField("QUUOM", "QUUOM", JdeDataType.String, 4),
        new JdeField("QUPRIC", "QUPRIC", JdeDataType.Numeric),
        new JdeField("QUUPRC", "QUUPRC", JdeDataType.Numeric),
        new JdeField("QUAEXP", "QUAEXP", JdeDataType.Numeric),
        new JdeField("QUBCLF", "QUBCLF", JdeDataType.String, 20),
        new JdeField("QUBRAAIP", "QUBRAAIP", JdeDataType.Numeric),
        new JdeField("QUBBCL", "QUBBCL", JdeDataType.Numeric),
        new JdeField("QUBBIR", "QUBBIR", JdeDataType.Numeric),
        new JdeField("QUBRAAIC", "QUBRAAIC", JdeDataType.Numeric),
        new JdeField("QUBRAVCI", "QUBRAVCI", JdeDataType.Numeric),
        new JdeField("QUBREP", "QUBREP", JdeDataType.Numeric),
        new JdeField("QUBBIS", "QUBBIS", JdeDataType.Numeric),
        new JdeField("QUBVIS", "QUBVIS", JdeDataType.Numeric),
        new JdeField("QUBSTT", "QUBSTT", JdeDataType.String, 4),
        new JdeField("QUBST1", "QUBST1", JdeDataType.String, 6),
        new JdeField("QUBDIZ", "QUBDIZ", JdeDataType.Numeric),
        new JdeField("QUBDES", "QUBDES", JdeDataType.Numeric),
        new JdeField("QUBRATDF", "QUBRATDF", JdeDataType.Numeric),
        new JdeField("QUBBTP", "QUBBTP", JdeDataType.Numeric),
        new JdeField("QUBIPI", "QUBIPI", JdeDataType.Numeric),
        new JdeField("QUBBCS", "QUBBCS", JdeDataType.Numeric),
        new JdeField("QUBISS", "QUBISS", JdeDataType.Numeric),
        new JdeField("QUBRAAIS", "QUBRAAIS", JdeDataType.Numeric),
        new JdeField("QUBRAITC", "QUBRAITC", JdeDataType.String, 2),
        new JdeField("QUBRABIP", "QUBRABIP", JdeDataType.Numeric),
        new JdeField("QUBRAITP", "QUBRAITP", JdeDataType.String, 2),
        new JdeField("QUBRAPBR", "QUBRAPBR", JdeDataType.Numeric),
        new JdeField("QUBRAUDP", "QUBRAUDP", JdeDataType.String, 4),
        new JdeField("QUTRTY", "QUTRTY", JdeDataType.String, 6),
        new JdeField("QUUSER", "QUUSER", JdeDataType.String, 20),
        new JdeField("QUPID", "QUPID", JdeDataType.String, 20),
        new JdeField("QUJOBN", "QUJOBN", JdeDataType.String, 20),
        new JdeField("QUUPMJ", "QUUPMJ", JdeDataType.Numeric),
        new JdeField("QUUPMT", "QUUPMT", JdeDataType.Numeric),
        new JdeField("QUTDAY", "QUTDAY", JdeDataType.Numeric),
        new JdeField("QUBRS1", "QUBRS1", JdeDataType.String, 6),
        new JdeField("QUBRS2", "QUBRS2", JdeDataType.String, 6),
        new JdeField("QUBRS3", "QUBRS3", JdeDataType.String, 6),
        new JdeField("QUBRN1", "QUBRN1", JdeDataType.Numeric),
        new JdeField("QUBRN2", "QUBRN2", JdeDataType.Numeric),
        new JdeField("QUBRN3", "QUBRN3", JdeDataType.Numeric),
        new JdeField("QUBRN4", "QUBRN4", JdeDataType.Numeric),
        new JdeField("QUBRN5", "QUBRN5", JdeDataType.Numeric),
        new JdeField("QUBRN6", "QUBRN6", JdeDataType.Numeric),
        new JdeField("QUBRN7", "QUBRN7", JdeDataType.Numeric),
        new JdeField("QUBRN8", "QUBRN8", JdeDataType.Numeric),
        new JdeField("QUBRN9", "QUBRN9", JdeDataType.Numeric),
        new JdeField("QUBRJD1", "QUBRJD1", JdeDataType.Numeric),
        new JdeField("QUBRJD2", "QUBRJD2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76111B_0", "Primary Key on QUBRANFK, QULNID", new[] { "QUBRANFK", "QULNID" }, isUnique: true, isPrimaryKey: true)
    };
}
