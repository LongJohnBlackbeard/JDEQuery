using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4572 - .
/// </summary>
public class F4572 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XRAN8.
        /// </summary>
        public const string XRAN8 = "XRAN8";

        /// <summary>
        /// XRPLANID.
        /// </summary>
        public const string XRPLANID = "XRPLANID";

        /// <summary>
        /// XRPLNAME.
        /// </summary>
        public const string XRPLNAME = "XRPLNAME";

        /// <summary>
        /// XRPROMID.
        /// </summary>
        public const string XRPROMID = "XRPROMID";

        /// <summary>
        /// XRPROWID.
        /// </summary>
        public const string XRPROWID = "XRPROWID";

        /// <summary>
        /// XRPRNAME.
        /// </summary>
        public const string XRPRNAME = "XRPRNAME";

        /// <summary>
        /// XREFTJ.
        /// </summary>
        public const string XREFTJ = "XREFTJ";

        /// <summary>
        /// XREXDJ.
        /// </summary>
        public const string XREXDJ = "XREXDJ";

        /// <summary>
        /// XRPRDTID.
        /// </summary>
        public const string XRPRDTID = "XRPRDTID";

        /// <summary>
        /// XRITM.
        /// </summary>
        public const string XRITM = "XRITM";

        /// <summary>
        /// XRCOSTYP.
        /// </summary>
        public const string XRCOSTYP = "XRCOSTYP";

        /// <summary>
        /// XRATID.
        /// </summary>
        public const string XRATID = "XRATID";

        /// <summary>
        /// XRAST.
        /// </summary>
        public const string XRAST = "XRAST";

        /// <summary>
        /// XRPRCODE.
        /// </summary>
        public const string XRPRCODE = "XRPRCODE";

        /// <summary>
        /// XRPRDAT1.
        /// </summary>
        public const string XRPRDAT1 = "XRPRDAT1";

        /// <summary>
        /// XRPRDAT2.
        /// </summary>
        public const string XRPRDAT2 = "XRPRDAT2";

        /// <summary>
        /// XRPRAMNT.
        /// </summary>
        public const string XRPRAMNT = "XRPRAMNT";

        /// <summary>
        /// XRPRNUMB.
        /// </summary>
        public const string XRPRNUMB = "XRPRNUMB";

        /// <summary>
        /// XRPRREFR.
        /// </summary>
        public const string XRPRREFR = "XRPRREFR";

        /// <summary>
        /// XRPROMFL.
        /// </summary>
        public const string XRPROMFL = "XRPROMFL";

        /// <summary>
        /// XRURCD.
        /// </summary>
        public const string XRURCD = "XRURCD";

        /// <summary>
        /// XRURDT.
        /// </summary>
        public const string XRURDT = "XRURDT";

        /// <summary>
        /// XRURAT.
        /// </summary>
        public const string XRURAT = "XRURAT";

        /// <summary>
        /// XRURAB.
        /// </summary>
        public const string XRURAB = "XRURAB";

        /// <summary>
        /// XRURRF.
        /// </summary>
        public const string XRURRF = "XRURRF";

        /// <summary>
        /// XRTORG.
        /// </summary>
        public const string XRTORG = "XRTORG";

        /// <summary>
        /// XRUSER.
        /// </summary>
        public const string XRUSER = "XRUSER";

        /// <summary>
        /// XRPID.
        /// </summary>
        public const string XRPID = "XRPID";

        /// <summary>
        /// XRJOBN.
        /// </summary>
        public const string XRJOBN = "XRJOBN";

        /// <summary>
        /// XRUPMJ.
        /// </summary>
        public const string XRUPMJ = "XRUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4572";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XRAN8", "XRAN8", JdeDataType.Numeric),
        new JdeField("XRPLANID", "XRPLANID", JdeDataType.String, 30),
        new JdeField("XRPLNAME", "XRPLNAME", JdeDataType.String, 100),
        new JdeField("XRPROMID", "XRPROMID", JdeDataType.String, 30),
        new JdeField("XRPROWID", "XRPROWID", JdeDataType.String, 30),
        new JdeField("XRPRNAME", "XRPRNAME", JdeDataType.String, 100),
        new JdeField("XREFTJ", "XREFTJ", JdeDataType.Numeric),
        new JdeField("XREXDJ", "XREXDJ", JdeDataType.Numeric),
        new JdeField("XRPRDTID", "XRPRDTID", JdeDataType.String, 30),
        new JdeField("XRITM", "XRITM", JdeDataType.Numeric),
        new JdeField("XRCOSTYP", "XRCOSTYP", JdeDataType.String, 2),
        new JdeField("XRATID", "XRATID", JdeDataType.Numeric, null, true, true),
        new JdeField("XRAST", "XRAST", JdeDataType.String, 16),
        new JdeField("XRPRCODE", "XRPRCODE", JdeDataType.String, 4),
        new JdeField("XRPRDAT1", "XRPRDAT1", JdeDataType.Numeric),
        new JdeField("XRPRDAT2", "XRPRDAT2", JdeDataType.Numeric),
        new JdeField("XRPRAMNT", "XRPRAMNT", JdeDataType.Numeric),
        new JdeField("XRPRNUMB", "XRPRNUMB", JdeDataType.Numeric),
        new JdeField("XRPRREFR", "XRPRREFR", JdeDataType.String, 60),
        new JdeField("XRPROMFL", "XRPROMFL", JdeDataType.String, 2),
        new JdeField("XRURCD", "XRURCD", JdeDataType.String, 4),
        new JdeField("XRURDT", "XRURDT", JdeDataType.Numeric),
        new JdeField("XRURAT", "XRURAT", JdeDataType.Numeric),
        new JdeField("XRURAB", "XRURAB", JdeDataType.Numeric),
        new JdeField("XRURRF", "XRURRF", JdeDataType.String, 30),
        new JdeField("XRTORG", "XRTORG", JdeDataType.String, 20),
        new JdeField("XRUSER", "XRUSER", JdeDataType.String, 20),
        new JdeField("XRPID", "XRPID", JdeDataType.String, 20),
        new JdeField("XRJOBN", "XRJOBN", JdeDataType.String, 20),
        new JdeField("XRUPMJ", "XRUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4572_0", "Primary Key on XRATID", new[] { "XRATID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4572_2", "Index on XRPLANID", new[] { "XRPLANID" }),
        new JdeIndex("F4572_3", "Index on XRPROMID", new[] { "XRPROMID" }),
        new JdeIndex("F4572_4", "Index on XRPRDTID", new[] { "XRPRDTID" })
    };
}
