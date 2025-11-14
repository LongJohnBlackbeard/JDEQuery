using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4572ZP - .
/// </summary>
public class F4572ZP : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGEDUS.
        /// </summary>
        public const string PGEDUS = "PGEDUS";

        /// <summary>
        /// PGEDBT.
        /// </summary>
        public const string PGEDBT = "PGEDBT";

        /// <summary>
        /// PGEDTN.
        /// </summary>
        public const string PGEDTN = "PGEDTN";

        /// <summary>
        /// PGEDLN.
        /// </summary>
        public const string PGEDLN = "PGEDLN";

        /// <summary>
        /// PGTNTY.
        /// </summary>
        public const string PGTNTY = "PGTNTY";

        /// <summary>
        /// PGTNAC.
        /// </summary>
        public const string PGTNAC = "PGTNAC";

        /// <summary>
        /// PGEDSP.
        /// </summary>
        public const string PGEDSP = "PGEDSP";

        /// <summary>
        /// PGEDTY.
        /// </summary>
        public const string PGEDTY = "PGEDTY";

        /// <summary>
        /// PGEDSQ.
        /// </summary>
        public const string PGEDSQ = "PGEDSQ";

        /// <summary>
        /// PGEDCT.
        /// </summary>
        public const string PGEDCT = "PGEDCT";

        /// <summary>
        /// PGEDTS.
        /// </summary>
        public const string PGEDTS = "PGEDTS";

        /// <summary>
        /// PGEDFT.
        /// </summary>
        public const string PGEDFT = "PGEDFT";

        /// <summary>
        /// PGEDDT.
        /// </summary>
        public const string PGEDDT = "PGEDDT";

        /// <summary>
        /// PGEDER.
        /// </summary>
        public const string PGEDER = "PGEDER";

        /// <summary>
        /// PGEDDL.
        /// </summary>
        public const string PGEDDL = "PGEDDL";

        /// <summary>
        /// PGDRIN.
        /// </summary>
        public const string PGDRIN = "PGDRIN";

        /// <summary>
        /// PGPLANID.
        /// </summary>
        public const string PGPLANID = "PGPLANID";

        /// <summary>
        /// PGPLNAME.
        /// </summary>
        public const string PGPLNAME = "PGPLNAME";

        /// <summary>
        /// PGPROMID.
        /// </summary>
        public const string PGPROMID = "PGPROMID";

        /// <summary>
        /// PGPRNAME.
        /// </summary>
        public const string PGPRNAME = "PGPRNAME";

        /// <summary>
        /// PGEFTJ.
        /// </summary>
        public const string PGEFTJ = "PGEFTJ";

        /// <summary>
        /// PGEXDJ.
        /// </summary>
        public const string PGEXDJ = "PGEXDJ";

        /// <summary>
        /// PGAN8.
        /// </summary>
        public const string PGAN8 = "PGAN8";

        /// <summary>
        /// PGITM.
        /// </summary>
        public const string PGITM = "PGITM";

        /// <summary>
        /// PGLITM.
        /// </summary>
        public const string PGLITM = "PGLITM";

        /// <summary>
        /// PGAITM.
        /// </summary>
        public const string PGAITM = "PGAITM";

        /// <summary>
        /// PGCRCD.
        /// </summary>
        public const string PGCRCD = "PGCRCD";

        /// <summary>
        /// PGUOM.
        /// </summary>
        public const string PGUOM = "PGUOM";

        /// <summary>
        /// PGCOSTYP.
        /// </summary>
        public const string PGCOSTYP = "PGCOSTYP";

        /// <summary>
        /// PGPROMAA.
        /// </summary>
        public const string PGPROMAA = "PGPROMAA";

        /// <summary>
        /// PGDTAI.
        /// </summary>
        public const string PGDTAI = "PGDTAI";

        /// <summary>
        /// PGPRPURG.
        /// </summary>
        public const string PGPRPURG = "PGPRPURG";

        /// <summary>
        /// PGPRMASK.
        /// </summary>
        public const string PGPRMASK = "PGPRMASK";

        /// <summary>
        /// PGPRCODE.
        /// </summary>
        public const string PGPRCODE = "PGPRCODE";

        /// <summary>
        /// PGPRDAT1.
        /// </summary>
        public const string PGPRDAT1 = "PGPRDAT1";

        /// <summary>
        /// PGPRDAT2.
        /// </summary>
        public const string PGPRDAT2 = "PGPRDAT2";

        /// <summary>
        /// PGPRAMNT.
        /// </summary>
        public const string PGPRAMNT = "PGPRAMNT";

        /// <summary>
        /// PGPRNUMB.
        /// </summary>
        public const string PGPRNUMB = "PGPRNUMB";

        /// <summary>
        /// PGPRREFR.
        /// </summary>
        public const string PGPRREFR = "PGPRREFR";

        /// <summary>
        /// PGPROMFL.
        /// </summary>
        public const string PGPROMFL = "PGPROMFL";

        /// <summary>
        /// PGURRF.
        /// </summary>
        public const string PGURRF = "PGURRF";

        /// <summary>
        /// PGURCD.
        /// </summary>
        public const string PGURCD = "PGURCD";

        /// <summary>
        /// PGURDT.
        /// </summary>
        public const string PGURDT = "PGURDT";

        /// <summary>
        /// PGURAT.
        /// </summary>
        public const string PGURAT = "PGURAT";

        /// <summary>
        /// PGURAB.
        /// </summary>
        public const string PGURAB = "PGURAB";

        /// <summary>
        /// PGTORG.
        /// </summary>
        public const string PGTORG = "PGTORG";

        /// <summary>
        /// PGUSER.
        /// </summary>
        public const string PGUSER = "PGUSER";

        /// <summary>
        /// PGPID.
        /// </summary>
        public const string PGPID = "PGPID";

        /// <summary>
        /// PGJOBN.
        /// </summary>
        public const string PGJOBN = "PGJOBN";

        /// <summary>
        /// PGUPMJ.
        /// </summary>
        public const string PGUPMJ = "PGUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4572ZP";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGEDUS", "PGEDUS", JdeDataType.String, 20, true, true),
        new JdeField("PGEDBT", "PGEDBT", JdeDataType.String, 30, true, true),
        new JdeField("PGEDTN", "PGEDTN", JdeDataType.String, 44, true, true),
        new JdeField("PGEDLN", "PGEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PGTNTY", "PGTNTY", JdeDataType.String, 4),
        new JdeField("PGTNAC", "PGTNAC", JdeDataType.String, 4),
        new JdeField("PGEDSP", "PGEDSP", JdeDataType.String, 2),
        new JdeField("PGEDTY", "PGEDTY", JdeDataType.String, 2),
        new JdeField("PGEDSQ", "PGEDSQ", JdeDataType.Numeric),
        new JdeField("PGEDCT", "PGEDCT", JdeDataType.String, 4),
        new JdeField("PGEDTS", "PGEDTS", JdeDataType.String, 12),
        new JdeField("PGEDFT", "PGEDFT", JdeDataType.String, 20),
        new JdeField("PGEDDT", "PGEDDT", JdeDataType.Numeric),
        new JdeField("PGEDER", "PGEDER", JdeDataType.String, 2),
        new JdeField("PGEDDL", "PGEDDL", JdeDataType.Numeric),
        new JdeField("PGDRIN", "PGDRIN", JdeDataType.String, 2),
        new JdeField("PGPLANID", "PGPLANID", JdeDataType.String, 30),
        new JdeField("PGPLNAME", "PGPLNAME", JdeDataType.String, 100),
        new JdeField("PGPROMID", "PGPROMID", JdeDataType.String, 30),
        new JdeField("PGPRNAME", "PGPRNAME", JdeDataType.String, 100),
        new JdeField("PGEFTJ", "PGEFTJ", JdeDataType.Numeric),
        new JdeField("PGEXDJ", "PGEXDJ", JdeDataType.Numeric),
        new JdeField("PGAN8", "PGAN8", JdeDataType.Numeric),
        new JdeField("PGITM", "PGITM", JdeDataType.Numeric),
        new JdeField("PGLITM", "PGLITM", JdeDataType.String, 50),
        new JdeField("PGAITM", "PGAITM", JdeDataType.String, 50),
        new JdeField("PGCRCD", "PGCRCD", JdeDataType.String, 6),
        new JdeField("PGUOM", "PGUOM", JdeDataType.String, 4),
        new JdeField("PGCOSTYP", "PGCOSTYP", JdeDataType.String, 2),
        new JdeField("PGPROMAA", "PGPROMAA", JdeDataType.Numeric),
        new JdeField("PGDTAI", "PGDTAI", JdeDataType.String, 20),
        new JdeField("PGPRPURG", "PGPRPURG", JdeDataType.String, 2),
        new JdeField("PGPRMASK", "PGPRMASK", JdeDataType.String, 2),
        new JdeField("PGPRCODE", "PGPRCODE", JdeDataType.String, 4),
        new JdeField("PGPRDAT1", "PGPRDAT1", JdeDataType.Numeric),
        new JdeField("PGPRDAT2", "PGPRDAT2", JdeDataType.Numeric),
        new JdeField("PGPRAMNT", "PGPRAMNT", JdeDataType.Numeric),
        new JdeField("PGPRNUMB", "PGPRNUMB", JdeDataType.Numeric),
        new JdeField("PGPRREFR", "PGPRREFR", JdeDataType.String, 60),
        new JdeField("PGPROMFL", "PGPROMFL", JdeDataType.String, 2),
        new JdeField("PGURRF", "PGURRF", JdeDataType.String, 30),
        new JdeField("PGURCD", "PGURCD", JdeDataType.String, 4),
        new JdeField("PGURDT", "PGURDT", JdeDataType.Numeric),
        new JdeField("PGURAT", "PGURAT", JdeDataType.Numeric),
        new JdeField("PGURAB", "PGURAB", JdeDataType.Numeric),
        new JdeField("PGTORG", "PGTORG", JdeDataType.String, 20),
        new JdeField("PGUSER", "PGUSER", JdeDataType.String, 20),
        new JdeField("PGPID", "PGPID", JdeDataType.String, 20),
        new JdeField("PGJOBN", "PGJOBN", JdeDataType.String, 20),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4572ZP_0", "Primary Key on PGEDUS, PGEDBT, PGEDTN, PGEDLN", new[] { "PGEDUS", "PGEDBT", "PGEDTN", "PGEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
