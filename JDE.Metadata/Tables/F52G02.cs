using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G02 - .
/// </summary>
public class F52G02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSAID.
        /// </summary>
        public const string BSAID = "BSAID";

        /// <summary>
        /// BSCTRY.
        /// </summary>
        public const string BSCTRY = "BSCTRY";

        /// <summary>
        /// BSFY.
        /// </summary>
        public const string BSFY = "BSFY";

        /// <summary>
        /// BSLT.
        /// </summary>
        public const string BSLT = "BSLT";

        /// <summary>
        /// BSSEGMID.
        /// </summary>
        public const string BSSEGMID = "BSSEGMID";

        /// <summary>
        /// BSPOOLID.
        /// </summary>
        public const string BSPOOLID = "BSPOOLID";

        /// <summary>
        /// BSBUCA.
        /// </summary>
        public const string BSBUCA = "BSBUCA";

        /// <summary>
        /// BSEPGC.
        /// </summary>
        public const string BSEPGC = "BSEPGC";

        /// <summary>
        /// BSJPGC.
        /// </summary>
        public const string BSJPGC = "BSJPGC";

        /// <summary>
        /// BSSBL.
        /// </summary>
        public const string BSSBL = "BSSBL";

        /// <summary>
        /// BSSBLT.
        /// </summary>
        public const string BSSBLT = "BSSBLT";

        /// <summary>
        /// BSCRCD.
        /// </summary>
        public const string BSCRCD = "BSCRCD";

        /// <summary>
        /// BSCRCX.
        /// </summary>
        public const string BSCRCX = "BSCRCX";

        /// <summary>
        /// BSCO.
        /// </summary>
        public const string BSCO = "BSCO";

        /// <summary>
        /// BSAN01.
        /// </summary>
        public const string BSAN01 = "BSAN01";

        /// <summary>
        /// BSAN02.
        /// </summary>
        public const string BSAN02 = "BSAN02";

        /// <summary>
        /// BSAN03.
        /// </summary>
        public const string BSAN03 = "BSAN03";

        /// <summary>
        /// BSAN04.
        /// </summary>
        public const string BSAN04 = "BSAN04";

        /// <summary>
        /// BSAN05.
        /// </summary>
        public const string BSAN05 = "BSAN05";

        /// <summary>
        /// BSAN06.
        /// </summary>
        public const string BSAN06 = "BSAN06";

        /// <summary>
        /// BSAN07.
        /// </summary>
        public const string BSAN07 = "BSAN07";

        /// <summary>
        /// BSAN08.
        /// </summary>
        public const string BSAN08 = "BSAN08";

        /// <summary>
        /// BSAN09.
        /// </summary>
        public const string BSAN09 = "BSAN09";

        /// <summary>
        /// BSAN10.
        /// </summary>
        public const string BSAN10 = "BSAN10";

        /// <summary>
        /// BSAN11.
        /// </summary>
        public const string BSAN11 = "BSAN11";

        /// <summary>
        /// BSAN12.
        /// </summary>
        public const string BSAN12 = "BSAN12";

        /// <summary>
        /// BSAN13.
        /// </summary>
        public const string BSAN13 = "BSAN13";

        /// <summary>
        /// BSAN14.
        /// </summary>
        public const string BSAN14 = "BSAN14";

        /// <summary>
        /// BSAAN01.
        /// </summary>
        public const string BSAAN01 = "BSAAN01";

        /// <summary>
        /// BSAAN02.
        /// </summary>
        public const string BSAAN02 = "BSAAN02";

        /// <summary>
        /// BSAAN03.
        /// </summary>
        public const string BSAAN03 = "BSAAN03";

        /// <summary>
        /// BSAAN04.
        /// </summary>
        public const string BSAAN04 = "BSAAN04";

        /// <summary>
        /// BSAAN05.
        /// </summary>
        public const string BSAAN05 = "BSAAN05";

        /// <summary>
        /// BSAAN06.
        /// </summary>
        public const string BSAAN06 = "BSAAN06";

        /// <summary>
        /// BSAAN07.
        /// </summary>
        public const string BSAAN07 = "BSAAN07";

        /// <summary>
        /// BSAAN08.
        /// </summary>
        public const string BSAAN08 = "BSAAN08";

        /// <summary>
        /// BSAAN09.
        /// </summary>
        public const string BSAAN09 = "BSAAN09";

        /// <summary>
        /// BSAAN10.
        /// </summary>
        public const string BSAAN10 = "BSAAN10";

        /// <summary>
        /// BSAAN11.
        /// </summary>
        public const string BSAAN11 = "BSAAN11";

        /// <summary>
        /// BSAAN12.
        /// </summary>
        public const string BSAAN12 = "BSAAN12";

        /// <summary>
        /// BSAAN13.
        /// </summary>
        public const string BSAAN13 = "BSAAN13";

        /// <summary>
        /// BSAAN14.
        /// </summary>
        public const string BSAAN14 = "BSAAN14";

        /// <summary>
        /// BSPRGF.
        /// </summary>
        public const string BSPRGF = "BSPRGF";

        /// <summary>
        /// BSMCU.
        /// </summary>
        public const string BSMCU = "BSMCU";

        /// <summary>
        /// BSOBJ.
        /// </summary>
        public const string BSOBJ = "BSOBJ";

        /// <summary>
        /// BSSUB.
        /// </summary>
        public const string BSSUB = "BSSUB";

        /// <summary>
        /// BSPID.
        /// </summary>
        public const string BSPID = "BSPID";

        /// <summary>
        /// BSMKEY.
        /// </summary>
        public const string BSMKEY = "BSMKEY";

        /// <summary>
        /// BSUSER.
        /// </summary>
        public const string BSUSER = "BSUSER";

        /// <summary>
        /// BSUPMJ.
        /// </summary>
        public const string BSUPMJ = "BSUPMJ";

        /// <summary>
        /// BSUPMT.
        /// </summary>
        public const string BSUPMT = "BSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSAID", "BSAID", JdeDataType.String, 16, true, true),
        new JdeField("BSCTRY", "BSCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("BSFY", "BSFY", JdeDataType.Numeric, null, true, true),
        new JdeField("BSLT", "BSLT", JdeDataType.String, 4, true, true),
        new JdeField("BSSEGMID", "BSSEGMID", JdeDataType.String, 6, true, true),
        new JdeField("BSPOOLID", "BSPOOLID", JdeDataType.String, 8, true, true),
        new JdeField("BSBUCA", "BSBUCA", JdeDataType.String, 10, true, true),
        new JdeField("BSEPGC", "BSEPGC", JdeDataType.String, 6, true, true),
        new JdeField("BSJPGC", "BSJPGC", JdeDataType.String, 6, true, true),
        new JdeField("BSSBL", "BSSBL", JdeDataType.String, 16, true, true),
        new JdeField("BSSBLT", "BSSBLT", JdeDataType.String, 2, true, true),
        new JdeField("BSCRCD", "BSCRCD", JdeDataType.String, 6, true, true),
        new JdeField("BSCRCX", "BSCRCX", JdeDataType.String, 6),
        new JdeField("BSCO", "BSCO", JdeDataType.String, 10),
        new JdeField("BSAN01", "BSAN01", JdeDataType.Numeric),
        new JdeField("BSAN02", "BSAN02", JdeDataType.Numeric),
        new JdeField("BSAN03", "BSAN03", JdeDataType.Numeric),
        new JdeField("BSAN04", "BSAN04", JdeDataType.Numeric),
        new JdeField("BSAN05", "BSAN05", JdeDataType.Numeric),
        new JdeField("BSAN06", "BSAN06", JdeDataType.Numeric),
        new JdeField("BSAN07", "BSAN07", JdeDataType.Numeric),
        new JdeField("BSAN08", "BSAN08", JdeDataType.Numeric),
        new JdeField("BSAN09", "BSAN09", JdeDataType.Numeric),
        new JdeField("BSAN10", "BSAN10", JdeDataType.Numeric),
        new JdeField("BSAN11", "BSAN11", JdeDataType.Numeric),
        new JdeField("BSAN12", "BSAN12", JdeDataType.Numeric),
        new JdeField("BSAN13", "BSAN13", JdeDataType.Numeric),
        new JdeField("BSAN14", "BSAN14", JdeDataType.Numeric),
        new JdeField("BSAAN01", "BSAAN01", JdeDataType.Numeric),
        new JdeField("BSAAN02", "BSAAN02", JdeDataType.Numeric),
        new JdeField("BSAAN03", "BSAAN03", JdeDataType.Numeric),
        new JdeField("BSAAN04", "BSAAN04", JdeDataType.Numeric),
        new JdeField("BSAAN05", "BSAAN05", JdeDataType.Numeric),
        new JdeField("BSAAN06", "BSAAN06", JdeDataType.Numeric),
        new JdeField("BSAAN07", "BSAAN07", JdeDataType.Numeric),
        new JdeField("BSAAN08", "BSAAN08", JdeDataType.Numeric),
        new JdeField("BSAAN09", "BSAAN09", JdeDataType.Numeric),
        new JdeField("BSAAN10", "BSAAN10", JdeDataType.Numeric),
        new JdeField("BSAAN11", "BSAAN11", JdeDataType.Numeric),
        new JdeField("BSAAN12", "BSAAN12", JdeDataType.Numeric),
        new JdeField("BSAAN13", "BSAAN13", JdeDataType.Numeric),
        new JdeField("BSAAN14", "BSAAN14", JdeDataType.Numeric),
        new JdeField("BSPRGF", "BSPRGF", JdeDataType.String, 2),
        new JdeField("BSMCU", "BSMCU", JdeDataType.String, 24),
        new JdeField("BSOBJ", "BSOBJ", JdeDataType.String, 12),
        new JdeField("BSSUB", "BSSUB", JdeDataType.String, 16),
        new JdeField("BSPID", "BSPID", JdeDataType.String, 20),
        new JdeField("BSMKEY", "BSMKEY", JdeDataType.String, 30),
        new JdeField("BSUSER", "BSUSER", JdeDataType.String, 20),
        new JdeField("BSUPMJ", "BSUPMJ", JdeDataType.Numeric),
        new JdeField("BSUPMT", "BSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G02_0", "Primary Key on BSAID, BSCTRY, BSFY, BSLT, BSSEGMID, BSPOOLID, BSBUCA, BSEPGC, BSJPGC, BSSBL, BSSBLT, BSCRCD", new[] { "BSAID", "BSCTRY", "BSFY", "BSLT", "BSSEGMID", "BSPOOLID", "BSBUCA", "BSEPGC", "BSJPGC", "BSSBL", "BSSBLT", "BSCRCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F52G02_2", "Index on BSAID, BSLT, BSSEGMID, BSPOOLID, BSBUCA, BSEPGC, BSJPGC, BSCRCD", new[] { "BSAID", "BSLT", "BSSEGMID", "BSPOOLID", "BSBUCA", "BSEPGC", "BSJPGC", "BSCRCD" }),
        new JdeIndex("F52G02_3", "Index on BSAID", new[] { "BSAID" })
    };
}
