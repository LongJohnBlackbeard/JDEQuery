using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0006 - .
/// </summary>
public class F75A0006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZEAN8.
        /// </summary>
        public const string ZEAN8 = "ZEAN8";

        /// <summary>
        /// ZESSN.
        /// </summary>
        public const string ZESSN = "ZESSN";

        /// <summary>
        /// ZETAXFNO.
        /// </summary>
        public const string ZETAXFNO = "ZETAXFNO";

        /// <summary>
        /// ZETFNFLG.
        /// </summary>
        public const string ZETFNFLG = "ZETFNFLG";

        /// <summary>
        /// ZEPENFLG.
        /// </summary>
        public const string ZEPENFLG = "ZEPENFLG";

        /// <summary>
        /// ZEUNSIXT.
        /// </summary>
        public const string ZEUNSIXT = "ZEUNSIXT";

        /// <summary>
        /// ZETFNSUP.
        /// </summary>
        public const string ZETFNSUP = "ZETFNSUP";

        /// <summary>
        /// ZERESIDENT.
        /// </summary>
        public const string ZERESIDENT = "ZERESIDENT";

        /// <summary>
        /// ZEEST.
        /// </summary>
        public const string ZEEST = "ZEEST";

        /// <summary>
        /// ZECTAXFF.
        /// </summary>
        public const string ZECTAXFF = "ZECTAXFF";

        /// <summary>
        /// ZEREBCLM.
        /// </summary>
        public const string ZEREBCLM = "ZEREBCLM";

        /// <summary>
        /// ZESAVREB.
        /// </summary>
        public const string ZESAVREB = "ZESAVREB";

        /// <summary>
        /// ZEFTAREB.
        /// </summary>
        public const string ZEFTAREB = "ZEFTAREB";

        /// <summary>
        /// ZESTDEBT.
        /// </summary>
        public const string ZESTDEBT = "ZESTDEBT";

        /// <summary>
        /// ZESCALE.
        /// </summary>
        public const string ZESCALE = "ZESCALE";

        /// <summary>
        /// ZESCLDER.
        /// </summary>
        public const string ZESCLDER = "ZESCLDER";

        /// <summary>
        /// ZEREDLEV.
        /// </summary>
        public const string ZEREDLEV = "ZEREDLEV";

        /// <summary>
        /// ZENDEP.
        /// </summary>
        public const string ZENDEP = "ZENDEP";

        /// <summary>
        /// ZEVARLEVY.
        /// </summary>
        public const string ZEVARLEVY = "ZEVARLEVY";

        /// <summary>
        /// ZESPOUSE.
        /// </summary>
        public const string ZESPOUSE = "ZESPOUSE";

        /// <summary>
        /// ZECINCOMF.
        /// </summary>
        public const string ZECINCOMF = "ZECINCOMF";

        /// <summary>
        /// ZELLOAD.
        /// </summary>
        public const string ZELLOAD = "ZELLOAD";

        /// <summary>
        /// ZEUPMJ.
        /// </summary>
        public const string ZEUPMJ = "ZEUPMJ";

        /// <summary>
        /// ZEUPMT.
        /// </summary>
        public const string ZEUPMT = "ZEUPMT";

        /// <summary>
        /// ZEPID.
        /// </summary>
        public const string ZEPID = "ZEPID";

        /// <summary>
        /// ZEJOBN.
        /// </summary>
        public const string ZEJOBN = "ZEJOBN";

        /// <summary>
        /// ZEUSER.
        /// </summary>
        public const string ZEUSER = "ZEUSER";

        /// <summary>
        /// ZEFLTTAX.
        /// </summary>
        public const string ZEFLTTAX = "ZEFLTTAX";

        /// <summary>
        /// ZEWKSE.
        /// </summary>
        public const string ZEWKSE = "ZEWKSE";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZEAN8", "ZEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZESSN", "ZESSN", JdeDataType.String, 40),
        new JdeField("ZETAXFNO", "ZETAXFNO", JdeDataType.String, 22),
        new JdeField("ZETFNFLG", "ZETFNFLG", JdeDataType.String, 2),
        new JdeField("ZEPENFLG", "ZEPENFLG", JdeDataType.String, 2),
        new JdeField("ZEUNSIXT", "ZEUNSIXT", JdeDataType.String, 2),
        new JdeField("ZETFNSUP", "ZETFNSUP", JdeDataType.String, 2),
        new JdeField("ZERESIDENT", "ZERESIDENT", JdeDataType.String, 2),
        new JdeField("ZEEST", "ZEEST", JdeDataType.String, 2),
        new JdeField("ZECTAXFF", "ZECTAXFF", JdeDataType.String, 2),
        new JdeField("ZEREBCLM", "ZEREBCLM", JdeDataType.Numeric),
        new JdeField("ZESAVREB", "ZESAVREB", JdeDataType.String, 2),
        new JdeField("ZEFTAREB", "ZEFTAREB", JdeDataType.String, 2),
        new JdeField("ZESTDEBT", "ZESTDEBT", JdeDataType.String, 2),
        new JdeField("ZESCALE", "ZESCALE", JdeDataType.String, 6),
        new JdeField("ZESCLDER", "ZESCLDER", JdeDataType.String, 6),
        new JdeField("ZEREDLEV", "ZEREDLEV", JdeDataType.String, 2),
        new JdeField("ZENDEP", "ZENDEP", JdeDataType.Numeric),
        new JdeField("ZEVARLEVY", "ZEVARLEVY", JdeDataType.String, 2),
        new JdeField("ZESPOUSE", "ZESPOUSE", JdeDataType.String, 2),
        new JdeField("ZECINCOMF", "ZECINCOMF", JdeDataType.String, 2),
        new JdeField("ZELLOAD", "ZELLOAD", JdeDataType.String, 2),
        new JdeField("ZEUPMJ", "ZEUPMJ", JdeDataType.Numeric),
        new JdeField("ZEUPMT", "ZEUPMT", JdeDataType.Numeric),
        new JdeField("ZEPID", "ZEPID", JdeDataType.String, 20),
        new JdeField("ZEJOBN", "ZEJOBN", JdeDataType.String, 20),
        new JdeField("ZEUSER", "ZEUSER", JdeDataType.String, 20),
        new JdeField("ZEFLTTAX", "ZEFLTTAX", JdeDataType.Numeric),
        new JdeField("ZEWKSE", "ZEWKSE", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0006_0", "Primary Key on ZEAN8", new[] { "ZEAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
