using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41514 - .
/// </summary>
public class F41514 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHMCU.
        /// </summary>
        public const string RHMCU = "RHMCU";

        /// <summary>
        /// RHITM.
        /// </summary>
        public const string RHITM = "RHITM";

        /// <summary>
        /// RHTKID.
        /// </summary>
        public const string RHTKID = "RHTKID";

        /// <summary>
        /// RHOPDT.
        /// </summary>
        public const string RHOPDT = "RHOPDT";

        /// <summary>
        /// RHRTTM.
        /// </summary>
        public const string RHRTTM = "RHRTTM";

        /// <summary>
        /// RHINCN.
        /// </summary>
        public const string RHINCN = "RHINCN";

        /// <summary>
        /// RHBUM0.
        /// </summary>
        public const string RHBUM0 = "RHBUM0";

        /// <summary>
        /// RHOUTG.
        /// </summary>
        public const string RHOUTG = "RHOUTG";

        /// <summary>
        /// RHBUM1.
        /// </summary>
        public const string RHBUM1 = "RHBUM1";

        /// <summary>
        /// RHOPNS.
        /// </summary>
        public const string RHOPNS = "RHOPNS";

        /// <summary>
        /// RHBUM2.
        /// </summary>
        public const string RHBUM2 = "RHBUM2";

        /// <summary>
        /// RHCLOS.
        /// </summary>
        public const string RHCLOS = "RHCLOS";

        /// <summary>
        /// RHBUM3.
        /// </summary>
        public const string RHBUM3 = "RHBUM3";

        /// <summary>
        /// RHGLQT.
        /// </summary>
        public const string RHGLQT = "RHGLQT";

        /// <summary>
        /// RHBUM4.
        /// </summary>
        public const string RHBUM4 = "RHBUM4";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHTDAY.
        /// </summary>
        public const string RHTDAY = "RHTDAY";

        /// <summary>
        /// RHINAM.
        /// </summary>
        public const string RHINAM = "RHINAM";

        /// <summary>
        /// RHHUM1.
        /// </summary>
        public const string RHHUM1 = "RHHUM1";

        /// <summary>
        /// RHINWG.
        /// </summary>
        public const string RHINWG = "RHINWG";

        /// <summary>
        /// RHHUM2.
        /// </summary>
        public const string RHHUM2 = "RHHUM2";

        /// <summary>
        /// RHOGAM.
        /// </summary>
        public const string RHOGAM = "RHOGAM";

        /// <summary>
        /// RHHUM3.
        /// </summary>
        public const string RHHUM3 = "RHHUM3";

        /// <summary>
        /// RHOGWG.
        /// </summary>
        public const string RHOGWG = "RHOGWG";

        /// <summary>
        /// RHHUM4.
        /// </summary>
        public const string RHHUM4 = "RHHUM4";

        /// <summary>
        /// RHOSAM.
        /// </summary>
        public const string RHOSAM = "RHOSAM";

        /// <summary>
        /// RHHUM5.
        /// </summary>
        public const string RHHUM5 = "RHHUM5";

        /// <summary>
        /// RHOSWG.
        /// </summary>
        public const string RHOSWG = "RHOSWG";

        /// <summary>
        /// RHHUM6.
        /// </summary>
        public const string RHHUM6 = "RHHUM6";

        /// <summary>
        /// RHCSAM.
        /// </summary>
        public const string RHCSAM = "RHCSAM";

        /// <summary>
        /// RHHUM7.
        /// </summary>
        public const string RHHUM7 = "RHHUM7";

        /// <summary>
        /// RHCSWG.
        /// </summary>
        public const string RHCSWG = "RHCSWG";

        /// <summary>
        /// RHHUM8.
        /// </summary>
        public const string RHHUM8 = "RHHUM8";

        /// <summary>
        /// RHGLAM.
        /// </summary>
        public const string RHGLAM = "RHGLAM";

        /// <summary>
        /// RHHUM9.
        /// </summary>
        public const string RHHUM9 = "RHHUM9";

        /// <summary>
        /// RHGLWG.
        /// </summary>
        public const string RHGLWG = "RHGLWG";

        /// <summary>
        /// RHHUMA.
        /// </summary>
        public const string RHHUMA = "RHHUMA";

        /// <summary>
        /// RHURRF.
        /// </summary>
        public const string RHURRF = "RHURRF";

        /// <summary>
        /// RHURDT.
        /// </summary>
        public const string RHURDT = "RHURDT";

        /// <summary>
        /// RHURCD.
        /// </summary>
        public const string RHURCD = "RHURCD";

        /// <summary>
        /// RHURAT.
        /// </summary>
        public const string RHURAT = "RHURAT";

        /// <summary>
        /// RHURAB.
        /// </summary>
        public const string RHURAB = "RHURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F41514";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHMCU", "RHMCU", JdeDataType.String, 24, true, true),
        new JdeField("RHITM", "RHITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RHTKID", "RHTKID", JdeDataType.String, 16, true, true),
        new JdeField("RHOPDT", "RHOPDT", JdeDataType.Numeric, null, true, true),
        new JdeField("RHRTTM", "RHRTTM", JdeDataType.Numeric, null, true, true),
        new JdeField("RHINCN", "RHINCN", JdeDataType.Numeric),
        new JdeField("RHBUM0", "RHBUM0", JdeDataType.String, 4),
        new JdeField("RHOUTG", "RHOUTG", JdeDataType.Numeric),
        new JdeField("RHBUM1", "RHBUM1", JdeDataType.String, 4),
        new JdeField("RHOPNS", "RHOPNS", JdeDataType.Numeric),
        new JdeField("RHBUM2", "RHBUM2", JdeDataType.String, 4),
        new JdeField("RHCLOS", "RHCLOS", JdeDataType.Numeric),
        new JdeField("RHBUM3", "RHBUM3", JdeDataType.String, 4),
        new JdeField("RHGLQT", "RHGLQT", JdeDataType.Numeric),
        new JdeField("RHBUM4", "RHBUM4", JdeDataType.String, 4),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHTDAY", "RHTDAY", JdeDataType.Numeric),
        new JdeField("RHINAM", "RHINAM", JdeDataType.Numeric),
        new JdeField("RHHUM1", "RHHUM1", JdeDataType.String, 4),
        new JdeField("RHINWG", "RHINWG", JdeDataType.Numeric),
        new JdeField("RHHUM2", "RHHUM2", JdeDataType.String, 4),
        new JdeField("RHOGAM", "RHOGAM", JdeDataType.Numeric),
        new JdeField("RHHUM3", "RHHUM3", JdeDataType.String, 4),
        new JdeField("RHOGWG", "RHOGWG", JdeDataType.Numeric),
        new JdeField("RHHUM4", "RHHUM4", JdeDataType.String, 4),
        new JdeField("RHOSAM", "RHOSAM", JdeDataType.Numeric),
        new JdeField("RHHUM5", "RHHUM5", JdeDataType.String, 4),
        new JdeField("RHOSWG", "RHOSWG", JdeDataType.Numeric),
        new JdeField("RHHUM6", "RHHUM6", JdeDataType.String, 4),
        new JdeField("RHCSAM", "RHCSAM", JdeDataType.Numeric),
        new JdeField("RHHUM7", "RHHUM7", JdeDataType.String, 4),
        new JdeField("RHCSWG", "RHCSWG", JdeDataType.Numeric),
        new JdeField("RHHUM8", "RHHUM8", JdeDataType.String, 4),
        new JdeField("RHGLAM", "RHGLAM", JdeDataType.Numeric),
        new JdeField("RHHUM9", "RHHUM9", JdeDataType.String, 4),
        new JdeField("RHGLWG", "RHGLWG", JdeDataType.Numeric),
        new JdeField("RHHUMA", "RHHUMA", JdeDataType.String, 4),
        new JdeField("RHURRF", "RHURRF", JdeDataType.String, 30),
        new JdeField("RHURDT", "RHURDT", JdeDataType.Numeric),
        new JdeField("RHURCD", "RHURCD", JdeDataType.String, 4),
        new JdeField("RHURAT", "RHURAT", JdeDataType.Numeric),
        new JdeField("RHURAB", "RHURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41514_0", "Primary Key on RHMCU, RHITM, RHTKID, RHOPDT, RHRTTM", new[] { "RHMCU", "RHITM", "RHTKID", "RHOPDT", "RHRTTM" }, isUnique: true, isPrimaryKey: true)
    };
}
