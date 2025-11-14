using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430030 - .
/// </summary>
public class F7430030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKCO.
        /// </summary>
        public const string PIKCO = "PIKCO";

        /// <summary>
        /// PIDCT.
        /// </summary>
        public const string PIDCT = "PIDCT";

        /// <summary>
        /// PIDOC.
        /// </summary>
        public const string PIDOC = "PIDOC";

        /// <summary>
        /// PIK74LECO.
        /// </summary>
        public const string PIK74LECO = "PIK74LECO";

        /// <summary>
        /// PINHRN.
        /// </summary>
        public const string PINHRN = "PINHRN";

        /// <summary>
        /// PIPTC.
        /// </summary>
        public const string PIPTC = "PIPTC";

        /// <summary>
        /// PIEFDJ.
        /// </summary>
        public const string PIEFDJ = "PIEFDJ";

        /// <summary>
        /// PIAN8.
        /// </summary>
        public const string PIAN8 = "PIAN8";

        /// <summary>
        /// PISHAN.
        /// </summary>
        public const string PISHAN = "PISHAN";

        /// <summary>
        /// PICRRM.
        /// </summary>
        public const string PICRRM = "PICRRM";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PICRR.
        /// </summary>
        public const string PICRR = "PICRR";

        /// <summary>
        /// PICRCM.
        /// </summary>
        public const string PICRCM = "PICRCM";

        /// <summary>
        /// PIERDJ.
        /// </summary>
        public const string PIERDJ = "PIERDJ";

        /// <summary>
        /// PIATXA.
        /// </summary>
        public const string PIATXA = "PIATXA";

        /// <summary>
        /// PIATXN.
        /// </summary>
        public const string PIATXN = "PIATXN";

        /// <summary>
        /// PISTAM.
        /// </summary>
        public const string PISTAM = "PISTAM";

        /// <summary>
        /// PIAG.
        /// </summary>
        public const string PIAG = "PIAG";

        /// <summary>
        /// PIWTUM.
        /// </summary>
        public const string PIWTUM = "PIWTUM";

        /// <summary>
        /// PIITWT.
        /// </summary>
        public const string PIITWT = "PIITWT";

        /// <summary>
        /// PIVLUM.
        /// </summary>
        public const string PIVLUM = "PIVLUM";

        /// <summary>
        /// PIITVL.
        /// </summary>
        public const string PIITVL = "PIITVL";

        /// <summary>
        /// PIDEL1.
        /// </summary>
        public const string PIDEL1 = "PIDEL1";

        /// <summary>
        /// PIDEL2.
        /// </summary>
        public const string PIDEL2 = "PIDEL2";

        /// <summary>
        /// PICARS.
        /// </summary>
        public const string PICARS = "PICARS";

        /// <summary>
        /// PIINVC.
        /// </summary>
        public const string PIINVC = "PIINVC";

        /// <summary>
        /// PIK74NPG.
        /// </summary>
        public const string PIK74NPG = "PIK74NPG";

        /// <summary>
        /// PILNGP.
        /// </summary>
        public const string PILNGP = "PILNGP";

        /// <summary>
        /// PITORG.
        /// </summary>
        public const string PITORG = "PITORG";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PIUPMT.
        /// </summary>
        public const string PIUPMT = "PIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7430030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PIK74LECO", "PIK74LECO", JdeDataType.String, 10),
        new JdeField("PINHRN", "PINHRN", JdeDataType.Numeric),
        new JdeField("PIPTC", "PIPTC", JdeDataType.String, 6),
        new JdeField("PIEFDJ", "PIEFDJ", JdeDataType.Numeric),
        new JdeField("PIAN8", "PIAN8", JdeDataType.Numeric),
        new JdeField("PISHAN", "PISHAN", JdeDataType.Numeric),
        new JdeField("PICRRM", "PICRRM", JdeDataType.String, 2),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PICRR", "PICRR", JdeDataType.Numeric),
        new JdeField("PICRCM", "PICRCM", JdeDataType.String, 2),
        new JdeField("PIERDJ", "PIERDJ", JdeDataType.Numeric),
        new JdeField("PIATXA", "PIATXA", JdeDataType.Numeric),
        new JdeField("PIATXN", "PIATXN", JdeDataType.Numeric),
        new JdeField("PISTAM", "PISTAM", JdeDataType.Numeric),
        new JdeField("PIAG", "PIAG", JdeDataType.Numeric),
        new JdeField("PIWTUM", "PIWTUM", JdeDataType.String, 4),
        new JdeField("PIITWT", "PIITWT", JdeDataType.Numeric),
        new JdeField("PIVLUM", "PIVLUM", JdeDataType.String, 4),
        new JdeField("PIITVL", "PIITVL", JdeDataType.Numeric),
        new JdeField("PIDEL1", "PIDEL1", JdeDataType.String, 60),
        new JdeField("PIDEL2", "PIDEL2", JdeDataType.String, 60),
        new JdeField("PICARS", "PICARS", JdeDataType.Numeric),
        new JdeField("PIINVC", "PIINVC", JdeDataType.Numeric),
        new JdeField("PIK74NPG", "PIK74NPG", JdeDataType.Numeric),
        new JdeField("PILNGP", "PILNGP", JdeDataType.String, 4),
        new JdeField("PITORG", "PITORG", JdeDataType.String, 20),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PIUPMT", "PIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430030_0", "Primary Key on PIKCO, PIDCT, PIDOC", new[] { "PIKCO", "PIDCT", "PIDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
