using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D010 - .
/// </summary>
public class F80D010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SFDOCO.
        /// </summary>
        public const string SFDOCO = "SFDOCO";

        /// <summary>
        /// SFDCTO.
        /// </summary>
        public const string SFDCTO = "SFDCTO";

        /// <summary>
        /// SFKCOO.
        /// </summary>
        public const string SFKCOO = "SFKCOO";

        /// <summary>
        /// SFLNID.
        /// </summary>
        public const string SFLNID = "SFLNID";

        /// <summary>
        /// SFAN8.
        /// </summary>
        public const string SFAN8 = "SFAN8";

        /// <summary>
        /// SFITM.
        /// </summary>
        public const string SFITM = "SFITM";

        /// <summary>
        /// SFMCU.
        /// </summary>
        public const string SFMCU = "SFMCU";

        /// <summary>
        /// SFEMCU.
        /// </summary>
        public const string SFEMCU = "SFEMCU";

        /// <summary>
        /// SFCO.
        /// </summary>
        public const string SFCO = "SFCO";

        /// <summary>
        /// SFSHAN.
        /// </summary>
        public const string SFSHAN = "SFSHAN";

        /// <summary>
        /// SFAEXP.
        /// </summary>
        public const string SFAEXP = "SFAEXP";

        /// <summary>
        /// SFCAEXP.
        /// </summary>
        public const string SFCAEXP = "SFCAEXP";

        /// <summary>
        /// SFCBACK.
        /// </summary>
        public const string SFCBACK = "SFCBACK";

        /// <summary>
        /// SFCADTC.
        /// </summary>
        public const string SFCADTC = "SFCADTC";

        /// <summary>
        /// SFSOQS.
        /// </summary>
        public const string SFSOQS = "SFSOQS";

        /// <summary>
        /// SFSOBK.
        /// </summary>
        public const string SFSOBK = "SFSOBK";

        /// <summary>
        /// SFUOM.
        /// </summary>
        public const string SFUOM = "SFUOM";

        /// <summary>
        /// SFUOM1.
        /// </summary>
        public const string SFUOM1 = "SFUOM1";

        /// <summary>
        /// SFTRDJ.
        /// </summary>
        public const string SFTRDJ = "SFTRDJ";

        /// <summary>
        /// SFDRQJ.
        /// </summary>
        public const string SFDRQJ = "SFDRQJ";

        /// <summary>
        /// SFPDDJ.
        /// </summary>
        public const string SFPDDJ = "SFPDDJ";

        /// <summary>
        /// SFRSDJ.
        /// </summary>
        public const string SFRSDJ = "SFRSDJ";

        /// <summary>
        /// SFIVD.
        /// </summary>
        public const string SFIVD = "SFIVD";

        /// <summary>
        /// SFPPDJ.
        /// </summary>
        public const string SFPPDJ = "SFPPDJ";

        /// <summary>
        /// SFADDJ.
        /// </summary>
        public const string SFADDJ = "SFADDJ";

        /// <summary>
        /// SFCNDJ.
        /// </summary>
        public const string SFCNDJ = "SFCNDJ";

        /// <summary>
        /// SFDGL.
        /// </summary>
        public const string SFDGL = "SFDGL";

        /// <summary>
        /// SFLTTR.
        /// </summary>
        public const string SFLTTR = "SFLTTR";

        /// <summary>
        /// SFNXTR.
        /// </summary>
        public const string SFNXTR = "SFNXTR";

        /// <summary>
        /// SFCRCD.
        /// </summary>
        public const string SFCRCD = "SFCRCD";

        /// <summary>
        /// SFUSER.
        /// </summary>
        public const string SFUSER = "SFUSER";

        /// <summary>
        /// SFPID.
        /// </summary>
        public const string SFPID = "SFPID";

        /// <summary>
        /// SFMKEY.
        /// </summary>
        public const string SFMKEY = "SFMKEY";

        /// <summary>
        /// SFUTIME.
        /// </summary>
        public const string SFUTIME = "SFUTIME";

        /// <summary>
        /// SFURCD.
        /// </summary>
        public const string SFURCD = "SFURCD";

        /// <summary>
        /// SFURDT.
        /// </summary>
        public const string SFURDT = "SFURDT";

        /// <summary>
        /// SFURAT.
        /// </summary>
        public const string SFURAT = "SFURAT";

        /// <summary>
        /// SFURAB.
        /// </summary>
        public const string SFURAB = "SFURAB";

        /// <summary>
        /// SFURRF.
        /// </summary>
        public const string SFURRF = "SFURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SFDOCO", "SFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SFDCTO", "SFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SFKCOO", "SFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SFLNID", "SFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SFAN8", "SFAN8", JdeDataType.Numeric),
        new JdeField("SFITM", "SFITM", JdeDataType.Numeric),
        new JdeField("SFMCU", "SFMCU", JdeDataType.String, 24),
        new JdeField("SFEMCU", "SFEMCU", JdeDataType.String, 24),
        new JdeField("SFCO", "SFCO", JdeDataType.String, 10),
        new JdeField("SFSHAN", "SFSHAN", JdeDataType.Numeric),
        new JdeField("SFAEXP", "SFAEXP", JdeDataType.Numeric),
        new JdeField("SFCAEXP", "SFCAEXP", JdeDataType.Numeric),
        new JdeField("SFCBACK", "SFCBACK", JdeDataType.Numeric),
        new JdeField("SFCADTC", "SFCADTC", JdeDataType.Numeric),
        new JdeField("SFSOQS", "SFSOQS", JdeDataType.Numeric),
        new JdeField("SFSOBK", "SFSOBK", JdeDataType.Numeric),
        new JdeField("SFUOM", "SFUOM", JdeDataType.String, 4),
        new JdeField("SFUOM1", "SFUOM1", JdeDataType.String, 4),
        new JdeField("SFTRDJ", "SFTRDJ", JdeDataType.Numeric),
        new JdeField("SFDRQJ", "SFDRQJ", JdeDataType.Numeric),
        new JdeField("SFPDDJ", "SFPDDJ", JdeDataType.Numeric),
        new JdeField("SFRSDJ", "SFRSDJ", JdeDataType.Numeric),
        new JdeField("SFIVD", "SFIVD", JdeDataType.Numeric),
        new JdeField("SFPPDJ", "SFPPDJ", JdeDataType.Numeric),
        new JdeField("SFADDJ", "SFADDJ", JdeDataType.Numeric),
        new JdeField("SFCNDJ", "SFCNDJ", JdeDataType.Numeric),
        new JdeField("SFDGL", "SFDGL", JdeDataType.Numeric),
        new JdeField("SFLTTR", "SFLTTR", JdeDataType.String, 6),
        new JdeField("SFNXTR", "SFNXTR", JdeDataType.String, 6),
        new JdeField("SFCRCD", "SFCRCD", JdeDataType.String, 6),
        new JdeField("SFUSER", "SFUSER", JdeDataType.String, 20),
        new JdeField("SFPID", "SFPID", JdeDataType.String, 20),
        new JdeField("SFMKEY", "SFMKEY", JdeDataType.String, 30),
        new JdeField("SFUTIME", "SFUTIME", JdeDataType.Date),
        new JdeField("SFURCD", "SFURCD", JdeDataType.String, 4),
        new JdeField("SFURDT", "SFURDT", JdeDataType.Numeric),
        new JdeField("SFURAT", "SFURAT", JdeDataType.Numeric),
        new JdeField("SFURAB", "SFURAB", JdeDataType.Numeric),
        new JdeField("SFURRF", "SFURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D010_0", "Primary Key on SFDOCO, SFDCTO, SFKCOO, SFLNID", new[] { "SFDOCO", "SFDCTO", "SFKCOO", "SFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
