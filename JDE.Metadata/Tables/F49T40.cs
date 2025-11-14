using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T40 - .
/// </summary>
public class F49T40 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCOTDOMAIN.
        /// </summary>
        public const string TCOTDOMAIN = "TCOTDOMAIN";

        /// <summary>
        /// TCOTSHPN.
        /// </summary>
        public const string TCOTSHPN = "TCOTSHPN";

        /// <summary>
        /// TCTRMNUM.
        /// </summary>
        public const string TCTRMNUM = "TCTRMNUM";

        /// <summary>
        /// TCOTORDRLS.
        /// </summary>
        public const string TCOTORDRLS = "TCOTORDRLS";

        /// <summary>
        /// TCOTSSHPN.
        /// </summary>
        public const string TCOTSSHPN = "TCOTSSHPN";

        /// <summary>
        /// TCOTBUYSEL.
        /// </summary>
        public const string TCOTBUYSEL = "TCOTBUYSEL";

        /// <summary>
        /// TCOTBLFCHG.
        /// </summary>
        public const string TCOTBLFCHG = "TCOTBLFCHG";

        /// <summary>
        /// TCCRCD.
        /// </summary>
        public const string TCCRCD = "TCCRCD";

        /// <summary>
        /// TCRSDJ.
        /// </summary>
        public const string TCRSDJ = "TCRSDJ";

        /// <summary>
        /// TCRSDT.
        /// </summary>
        public const string TCRSDT = "TCRSDT";

        /// <summary>
        /// TCOTE1REF1.
        /// </summary>
        public const string TCOTE1REF1 = "TCOTE1REF1";

        /// <summary>
        /// TCOTE1REF2.
        /// </summary>
        public const string TCOTE1REF2 = "TCOTE1REF2";

        /// <summary>
        /// TCOTE1REF3.
        /// </summary>
        public const string TCOTE1REF3 = "TCOTE1REF3";

        /// <summary>
        /// TCOTCHAR1.
        /// </summary>
        public const string TCOTCHAR1 = "TCOTCHAR1";

        /// <summary>
        /// TCOTCHAR2.
        /// </summary>
        public const string TCOTCHAR2 = "TCOTCHAR2";

        /// <summary>
        /// TCOTCHAR3.
        /// </summary>
        public const string TCOTCHAR3 = "TCOTCHAR3";

        /// <summary>
        /// TCOTMATH1.
        /// </summary>
        public const string TCOTMATH1 = "TCOTMATH1";

        /// <summary>
        /// TCOTMATH2.
        /// </summary>
        public const string TCOTMATH2 = "TCOTMATH2";

        /// <summary>
        /// TCOTMATH3.
        /// </summary>
        public const string TCOTMATH3 = "TCOTMATH3";

        /// <summary>
        /// TCURCD.
        /// </summary>
        public const string TCURCD = "TCURCD";

        /// <summary>
        /// TCURDT.
        /// </summary>
        public const string TCURDT = "TCURDT";

        /// <summary>
        /// TCURRF.
        /// </summary>
        public const string TCURRF = "TCURRF";

        /// <summary>
        /// TCURAT.
        /// </summary>
        public const string TCURAT = "TCURAT";

        /// <summary>
        /// TCURAB.
        /// </summary>
        public const string TCURAB = "TCURAB";

        /// <summary>
        /// TCOTERRFLG.
        /// </summary>
        public const string TCOTERRFLG = "TCOTERRFLG";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCTORG.
        /// </summary>
        public const string TCTORG = "TCTORG";

        /// <summary>
        /// TCJOBN.
        /// </summary>
        public const string TCJOBN = "TCJOBN";

        /// <summary>
        /// TCUUPMJ.
        /// </summary>
        public const string TCUUPMJ = "TCUUPMJ";

        /// <summary>
        /// TCDATETIME.
        /// </summary>
        public const string TCDATETIME = "TCDATETIME";
    }

    /// <inheritdoc />
    public override string TableName => "F49T40";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCOTDOMAIN", "TCOTDOMAIN", JdeDataType.String, 100, true, true),
        new JdeField("TCOTSHPN", "TCOTSHPN", JdeDataType.String, 100, true, true),
        new JdeField("TCTRMNUM", "TCTRMNUM", JdeDataType.String, 22, true, true),
        new JdeField("TCOTORDRLS", "TCOTORDRLS", JdeDataType.String, 100, true, true),
        new JdeField("TCOTSSHPN", "TCOTSSHPN", JdeDataType.String, 100, true, true),
        new JdeField("TCOTBUYSEL", "TCOTBUYSEL", JdeDataType.String, 2),
        new JdeField("TCOTBLFCHG", "TCOTBLFCHG", JdeDataType.Numeric),
        new JdeField("TCCRCD", "TCCRCD", JdeDataType.String, 6),
        new JdeField("TCRSDJ", "TCRSDJ", JdeDataType.Numeric),
        new JdeField("TCRSDT", "TCRSDT", JdeDataType.Numeric),
        new JdeField("TCOTE1REF1", "TCOTE1REF1", JdeDataType.String, 100),
        new JdeField("TCOTE1REF2", "TCOTE1REF2", JdeDataType.String, 100),
        new JdeField("TCOTE1REF3", "TCOTE1REF3", JdeDataType.String, 100),
        new JdeField("TCOTCHAR1", "TCOTCHAR1", JdeDataType.String, 2),
        new JdeField("TCOTCHAR2", "TCOTCHAR2", JdeDataType.String, 2),
        new JdeField("TCOTCHAR3", "TCOTCHAR3", JdeDataType.String, 2),
        new JdeField("TCOTMATH1", "TCOTMATH1", JdeDataType.Numeric),
        new JdeField("TCOTMATH2", "TCOTMATH2", JdeDataType.Numeric),
        new JdeField("TCOTMATH3", "TCOTMATH3", JdeDataType.Numeric),
        new JdeField("TCURCD", "TCURCD", JdeDataType.String, 4),
        new JdeField("TCURDT", "TCURDT", JdeDataType.Numeric),
        new JdeField("TCURRF", "TCURRF", JdeDataType.String, 30),
        new JdeField("TCURAT", "TCURAT", JdeDataType.Numeric),
        new JdeField("TCURAB", "TCURAB", JdeDataType.Numeric),
        new JdeField("TCOTERRFLG", "TCOTERRFLG", JdeDataType.String, 2),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCTORG", "TCTORG", JdeDataType.String, 20),
        new JdeField("TCJOBN", "TCJOBN", JdeDataType.String, 20),
        new JdeField("TCUUPMJ", "TCUUPMJ", JdeDataType.Date),
        new JdeField("TCDATETIME", "TCDATETIME", JdeDataType.String, 52)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T40_0", "Primary Key on TCOTDOMAIN, TCOTSHPN, TCTRMNUM, TCOTORDRLS, TCOTSSHPN", new[] { "TCOTDOMAIN", "TCOTSHPN", "TCTRMNUM", "TCOTORDRLS", "TCOTSSHPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49T40_2", "Index on TCOTDOMAIN, TCOTSHPN, TCTRMNUM, TCDATETIME, TCOTORDRLS, TCOTERRFLG", new[] { "TCOTDOMAIN", "TCOTSHPN", "TCTRMNUM", "TCDATETIME", "TCOTORDRLS", "TCOTERRFLG" }),
        new JdeIndex("F49T40_3", "Index on TCOTDOMAIN, TCOTSHPN, TCTRMNUM, TCOTERRFLG", new[] { "TCOTDOMAIN", "TCOTSHPN", "TCTRMNUM", "TCOTERRFLG" })
    };
}
