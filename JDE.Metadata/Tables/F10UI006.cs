using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10UI006 - .
/// </summary>
public class F10UI006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GEEDUS.
        /// </summary>
        public const string GEEDUS = "GEEDUS";

        /// <summary>
        /// GEEDTN.
        /// </summary>
        public const string GEEDTN = "GEEDTN";

        /// <summary>
        /// GEEDBT.
        /// </summary>
        public const string GEEDBT = "GEEDBT";

        /// <summary>
        /// GESERK.
        /// </summary>
        public const string GESERK = "GESERK";

        /// <summary>
        /// GERC5.
        /// </summary>
        public const string GERC5 = "GERC5";

        /// <summary>
        /// GEMCU1.
        /// </summary>
        public const string GEMCU1 = "GEMCU1";

        /// <summary>
        /// GEOBJ.
        /// </summary>
        public const string GEOBJ = "GEOBJ";

        /// <summary>
        /// GESUB.
        /// </summary>
        public const string GESUB = "GESUB";

        /// <summary>
        /// GEDL01.
        /// </summary>
        public const string GEDL01 = "GEDL01";

        /// <summary>
        /// GESBL.
        /// </summary>
        public const string GESBL = "GESBL";

        /// <summary>
        /// GESBLT.
        /// </summary>
        public const string GESBLT = "GESBLT";

        /// <summary>
        /// GECRCD.
        /// </summary>
        public const string GECRCD = "GECRCD";

        /// <summary>
        /// GECRCX.
        /// </summary>
        public const string GECRCX = "GECRCX";

        /// <summary>
        /// GEELGR.
        /// </summary>
        public const string GEELGR = "GEELGR";

        /// <summary>
        /// GEELFL.
        /// </summary>
        public const string GEELFL = "GEELFL";

        /// <summary>
        /// GEWRBU.
        /// </summary>
        public const string GEWRBU = "GEWRBU";

        /// <summary>
        /// GEWROB.
        /// </summary>
        public const string GEWROB = "GEWROB";

        /// <summary>
        /// GEWRSB.
        /// </summary>
        public const string GEWRSB = "GEWRSB";

        /// <summary>
        /// GEAPYC.
        /// </summary>
        public const string GEAPYC = "GEAPYC";

        /// <summary>
        /// GEAN01.
        /// </summary>
        public const string GEAN01 = "GEAN01";

        /// <summary>
        /// GEAN02.
        /// </summary>
        public const string GEAN02 = "GEAN02";

        /// <summary>
        /// GEAN03.
        /// </summary>
        public const string GEAN03 = "GEAN03";

        /// <summary>
        /// GEAN04.
        /// </summary>
        public const string GEAN04 = "GEAN04";

        /// <summary>
        /// GEAN05.
        /// </summary>
        public const string GEAN05 = "GEAN05";

        /// <summary>
        /// GEAN06.
        /// </summary>
        public const string GEAN06 = "GEAN06";

        /// <summary>
        /// GEAN07.
        /// </summary>
        public const string GEAN07 = "GEAN07";

        /// <summary>
        /// GEAN08.
        /// </summary>
        public const string GEAN08 = "GEAN08";

        /// <summary>
        /// GEAN09.
        /// </summary>
        public const string GEAN09 = "GEAN09";

        /// <summary>
        /// GEAN10.
        /// </summary>
        public const string GEAN10 = "GEAN10";

        /// <summary>
        /// GEAN11.
        /// </summary>
        public const string GEAN11 = "GEAN11";

        /// <summary>
        /// GEAN12.
        /// </summary>
        public const string GEAN12 = "GEAN12";

        /// <summary>
        /// GEAN13.
        /// </summary>
        public const string GEAN13 = "GEAN13";

        /// <summary>
        /// GEAN14.
        /// </summary>
        public const string GEAN14 = "GEAN14";

        /// <summary>
        /// GEAPYN.
        /// </summary>
        public const string GEAPYN = "GEAPYN";

        /// <summary>
        /// GEUPMJ.
        /// </summary>
        public const string GEUPMJ = "GEUPMJ";

        /// <summary>
        /// GEUPMT.
        /// </summary>
        public const string GEUPMT = "GEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10UI006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GEEDUS", "GEEDUS", JdeDataType.String, 20, true, true),
        new JdeField("GEEDTN", "GEEDTN", JdeDataType.String, 44, true, true),
        new JdeField("GEEDBT", "GEEDBT", JdeDataType.String, 30, true, true),
        new JdeField("GESERK", "GESERK", JdeDataType.Numeric, null, true, true),
        new JdeField("GERC5", "GERC5", JdeDataType.Numeric, null, true, true),
        new JdeField("GEMCU1", "GEMCU1", JdeDataType.String, 24),
        new JdeField("GEOBJ", "GEOBJ", JdeDataType.String, 12),
        new JdeField("GESUB", "GESUB", JdeDataType.String, 16),
        new JdeField("GEDL01", "GEDL01", JdeDataType.String, 60),
        new JdeField("GESBL", "GESBL", JdeDataType.String, 16),
        new JdeField("GESBLT", "GESBLT", JdeDataType.String, 2),
        new JdeField("GECRCD", "GECRCD", JdeDataType.String, 6),
        new JdeField("GECRCX", "GECRCX", JdeDataType.String, 6),
        new JdeField("GEELGR", "GEELGR", JdeDataType.String, 4),
        new JdeField("GEELFL", "GEELFL", JdeDataType.String, 2),
        new JdeField("GEWRBU", "GEWRBU", JdeDataType.String, 24),
        new JdeField("GEWROB", "GEWROB", JdeDataType.String, 12),
        new JdeField("GEWRSB", "GEWRSB", JdeDataType.String, 16),
        new JdeField("GEAPYC", "GEAPYC", JdeDataType.Numeric),
        new JdeField("GEAN01", "GEAN01", JdeDataType.Numeric),
        new JdeField("GEAN02", "GEAN02", JdeDataType.Numeric),
        new JdeField("GEAN03", "GEAN03", JdeDataType.Numeric),
        new JdeField("GEAN04", "GEAN04", JdeDataType.Numeric),
        new JdeField("GEAN05", "GEAN05", JdeDataType.Numeric),
        new JdeField("GEAN06", "GEAN06", JdeDataType.Numeric),
        new JdeField("GEAN07", "GEAN07", JdeDataType.Numeric),
        new JdeField("GEAN08", "GEAN08", JdeDataType.Numeric),
        new JdeField("GEAN09", "GEAN09", JdeDataType.Numeric),
        new JdeField("GEAN10", "GEAN10", JdeDataType.Numeric),
        new JdeField("GEAN11", "GEAN11", JdeDataType.Numeric),
        new JdeField("GEAN12", "GEAN12", JdeDataType.Numeric),
        new JdeField("GEAN13", "GEAN13", JdeDataType.Numeric),
        new JdeField("GEAN14", "GEAN14", JdeDataType.Numeric),
        new JdeField("GEAPYN", "GEAPYN", JdeDataType.Numeric),
        new JdeField("GEUPMJ", "GEUPMJ", JdeDataType.Numeric),
        new JdeField("GEUPMT", "GEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10UI006_0", "Primary Key on GEEDUS, GEEDTN, GEEDBT, GESERK, GERC5", new[] { "GEEDUS", "GEEDTN", "GEEDBT", "GESERK", "GERC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F10UI006_2", "Index on GEEDUS, GEEDTN, GEEDBT, GESERK, GEMCU1, GEOBJ, GESUB, GESBL, GESBLT, GECRCD", new[] { "GEEDUS", "GEEDTN", "GEEDBT", "GESERK", "GEMCU1", "GEOBJ", "GESUB", "GESBL", "GESBLT", "GECRCD" }),
        new JdeIndex("F10UI006_3", "Index on GEEDUS, GEEDTN, GEUPMJ, GEUPMT", new[] { "GEEDUS", "GEEDTN", "GEUPMJ", "GEUPMT" }),
        new JdeIndex("F10UI006_4", "Index on GEELFL, GEELGR, GEWRBU, GEWROB, GEWRSB", new[] { "GEELFL", "GEELGR", "GEWRBU", "GEWROB", "GEWRSB" })
    };
}
