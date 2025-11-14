using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04571 - .
/// </summary>
public class F04571 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KHHDC.
        /// </summary>
        public const string KHHDC = "KHHDC";

        /// <summary>
        /// KHGLBA.
        /// </summary>
        public const string KHGLBA = "KHGLBA";

        /// <summary>
        /// KHVERS.
        /// </summary>
        public const string KHVERS = "KHVERS";

        /// <summary>
        /// KHPYIN.
        /// </summary>
        public const string KHPYIN = "KHPYIN";

        /// <summary>
        /// KHCRCD.
        /// </summary>
        public const string KHCRCD = "KHCRCD";

        /// <summary>
        /// KHMCU.
        /// </summary>
        public const string KHMCU = "KHMCU";

        /// <summary>
        /// KHTORG.
        /// </summary>
        public const string KHTORG = "KHTORG";

        /// <summary>
        /// KHDEJ.
        /// </summary>
        public const string KHDEJ = "KHDEJ";

        /// <summary>
        /// KHTENT.
        /// </summary>
        public const string KHTENT = "KHTENT";

        /// <summary>
        /// KHNPYT.
        /// </summary>
        public const string KHNPYT = "KHNPYT";

        /// <summary>
        /// KHADSA.
        /// </summary>
        public const string KHADSA = "KHADSA";

        /// <summary>
        /// KHPAAP.
        /// </summary>
        public const string KHPAAP = "KHPAAP";

        /// <summary>
        /// KHUPYT.
        /// </summary>
        public const string KHUPYT = "KHUPYT";

        /// <summary>
        /// KHUAAP.
        /// </summary>
        public const string KHUAAP = "KHUAAP";

        /// <summary>
        /// KHUADS.
        /// </summary>
        public const string KHUADS = "KHUADS";

        /// <summary>
        /// KHCHKQ.
        /// </summary>
        public const string KHCHKQ = "KHCHKQ";

        /// <summary>
        /// KHATTQ.
        /// </summary>
        public const string KHATTQ = "KHATTQ";

        /// <summary>
        /// KHDBTQ.
        /// </summary>
        public const string KHDBTQ = "KHDBTQ";

        /// <summary>
        /// KHLFRM.
        /// </summary>
        public const string KHLFRM = "KHLFRM";

        /// <summary>
        /// KHPGMP.
        /// </summary>
        public const string KHPGMP = "KHPGMP";

        /// <summary>
        /// KHPGMR.
        /// </summary>
        public const string KHPGMR = "KHPGMR";

        /// <summary>
        /// KHPGMA.
        /// </summary>
        public const string KHPGMA = "KHPGMA";

        /// <summary>
        /// KHPGMD.
        /// </summary>
        public const string KHPGMD = "KHPGMD";

        /// <summary>
        /// KHCSUM.
        /// </summary>
        public const string KHCSUM = "KHCSUM";

        /// <summary>
        /// KHSQID.
        /// </summary>
        public const string KHSQID = "KHSQID";

        /// <summary>
        /// KHATT.
        /// </summary>
        public const string KHATT = "KHATT";

        /// <summary>
        /// KHPID.
        /// </summary>
        public const string KHPID = "KHPID";

        /// <summary>
        /// KHUSER.
        /// </summary>
        public const string KHUSER = "KHUSER";

        /// <summary>
        /// KHUPMJ.
        /// </summary>
        public const string KHUPMJ = "KHUPMJ";

        /// <summary>
        /// KHUPMT.
        /// </summary>
        public const string KHUPMT = "KHUPMT";

        /// <summary>
        /// KHJOBN.
        /// </summary>
        public const string KHJOBN = "KHJOBN";

        /// <summary>
        /// KHPVN.
        /// </summary>
        public const string KHPVN = "KHPVN";

        /// <summary>
        /// KHDVN.
        /// </summary>
        public const string KHDVN = "KHDVN";

        /// <summary>
        /// KHRVN.
        /// </summary>
        public const string KHRVN = "KHRVN";

        /// <summary>
        /// KHAVN.
        /// </summary>
        public const string KHAVN = "KHAVN";

        /// <summary>
        /// KHGFL3.
        /// </summary>
        public const string KHGFL3 = "KHGFL3";

        /// <summary>
        /// KHGFL4.
        /// </summary>
        public const string KHGFL4 = "KHGFL4";

        /// <summary>
        /// KHSNC.
        /// </summary>
        public const string KHSNC = "KHSNC";

        /// <summary>
        /// KHENC.
        /// </summary>
        public const string KHENC = "KHENC";
    }

    /// <inheritdoc />
    public override string TableName => "F04571";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KHHDC", "KHHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("KHGLBA", "KHGLBA", JdeDataType.String, 16),
        new JdeField("KHVERS", "KHVERS", JdeDataType.String, 20),
        new JdeField("KHPYIN", "KHPYIN", JdeDataType.String, 2),
        new JdeField("KHCRCD", "KHCRCD", JdeDataType.String, 6),
        new JdeField("KHMCU", "KHMCU", JdeDataType.String, 24),
        new JdeField("KHTORG", "KHTORG", JdeDataType.String, 20),
        new JdeField("KHDEJ", "KHDEJ", JdeDataType.Numeric),
        new JdeField("KHTENT", "KHTENT", JdeDataType.Numeric),
        new JdeField("KHNPYT", "KHNPYT", JdeDataType.Numeric),
        new JdeField("KHADSA", "KHADSA", JdeDataType.Numeric),
        new JdeField("KHPAAP", "KHPAAP", JdeDataType.Numeric),
        new JdeField("KHUPYT", "KHUPYT", JdeDataType.Numeric),
        new JdeField("KHUAAP", "KHUAAP", JdeDataType.Numeric),
        new JdeField("KHUADS", "KHUADS", JdeDataType.Numeric),
        new JdeField("KHCHKQ", "KHCHKQ", JdeDataType.String, 20),
        new JdeField("KHATTQ", "KHATTQ", JdeDataType.String, 20),
        new JdeField("KHDBTQ", "KHDBTQ", JdeDataType.String, 20),
        new JdeField("KHLFRM", "KHLFRM", JdeDataType.String, 40),
        new JdeField("KHPGMP", "KHPGMP", JdeDataType.String, 20),
        new JdeField("KHPGMR", "KHPGMR", JdeDataType.String, 20),
        new JdeField("KHPGMA", "KHPGMA", JdeDataType.String, 20),
        new JdeField("KHPGMD", "KHPGMD", JdeDataType.String, 20),
        new JdeField("KHCSUM", "KHCSUM", JdeDataType.String, 2),
        new JdeField("KHSQID", "KHSQID", JdeDataType.String, 20),
        new JdeField("KHATT", "KHATT", JdeDataType.String, 2),
        new JdeField("KHPID", "KHPID", JdeDataType.String, 20),
        new JdeField("KHUSER", "KHUSER", JdeDataType.String, 20),
        new JdeField("KHUPMJ", "KHUPMJ", JdeDataType.Numeric),
        new JdeField("KHUPMT", "KHUPMT", JdeDataType.Numeric),
        new JdeField("KHJOBN", "KHJOBN", JdeDataType.String, 20),
        new JdeField("KHPVN", "KHPVN", JdeDataType.String, 20),
        new JdeField("KHDVN", "KHDVN", JdeDataType.String, 20),
        new JdeField("KHRVN", "KHRVN", JdeDataType.String, 20),
        new JdeField("KHAVN", "KHAVN", JdeDataType.String, 20),
        new JdeField("KHGFL3", "KHGFL3", JdeDataType.String, 2),
        new JdeField("KHGFL4", "KHGFL4", JdeDataType.String, 2),
        new JdeField("KHSNC", "KHSNC", JdeDataType.Numeric),
        new JdeField("KHENC", "KHENC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04571_0", "Primary Key on KHHDC", new[] { "KHHDC" }, isUnique: true, isPrimaryKey: true)
    };
}
