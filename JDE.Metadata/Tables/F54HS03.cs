using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS03 - .
/// </summary>
public class F54HS03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S4HSINO.
        /// </summary>
        public const string S4HSINO = "S4HSINO";

        /// <summary>
        /// S4UKID.
        /// </summary>
        public const string S4UKID = "S4UKID";

        /// <summary>
        /// S4NUMB.
        /// </summary>
        public const string S4NUMB = "S4NUMB";

        /// <summary>
        /// S4DL01.
        /// </summary>
        public const string S4DL01 = "S4DL01";

        /// <summary>
        /// S4HSIDG.
        /// </summary>
        public const string S4HSIDG = "S4HSIDG";

        /// <summary>
        /// S4HSIDD.
        /// </summary>
        public const string S4HSIDD = "S4HSIDD";

        /// <summary>
        /// S4HSISED.
        /// </summary>
        public const string S4HSISED = "S4HSISED";

        /// <summary>
        /// S4HSIEQS.
        /// </summary>
        public const string S4HSIEQS = "S4HSIEQS";

        /// <summary>
        /// S4HSI3PE.
        /// </summary>
        public const string S4HSI3PE = "S4HSI3PE";

        /// <summary>
        /// S4HSI3PO.
        /// </summary>
        public const string S4HSI3PO = "S4HSI3PO";

        /// <summary>
        /// S4HSI3PC.
        /// </summary>
        public const string S4HSI3PC = "S4HSI3PC";

        /// <summary>
        /// S4HSIVM.
        /// </summary>
        public const string S4HSIVM = "S4HSIVM";

        /// <summary>
        /// S4HSIVC.
        /// </summary>
        public const string S4HSIVC = "S4HSIVC";

        /// <summary>
        /// S4HSIVV.
        /// </summary>
        public const string S4HSIVV = "S4HSIVV";

        /// <summary>
        /// S4HSIVR.
        /// </summary>
        public const string S4HSIVR = "S4HSIVR";

        /// <summary>
        /// S4HSIVP.
        /// </summary>
        public const string S4HSIVP = "S4HSIVP";

        /// <summary>
        /// S4HSIVT.
        /// </summary>
        public const string S4HSIVT = "S4HSIVT";

        /// <summary>
        /// S4HSIVN.
        /// </summary>
        public const string S4HSIVN = "S4HSIVN";

        /// <summary>
        /// S4ADDS.
        /// </summary>
        public const string S4ADDS = "S4ADDS";

        /// <summary>
        /// S4LNUM.
        /// </summary>
        public const string S4LNUM = "S4LNUM";

        /// <summary>
        /// S4HSIVO.
        /// </summary>
        public const string S4HSIVO = "S4HSIVO";

        /// <summary>
        /// S4HSIEO.
        /// </summary>
        public const string S4HSIEO = "S4HSIEO";

        /// <summary>
        /// S4HSIVD.
        /// </summary>
        public const string S4HSIVD = "S4HSIVD";

        /// <summary>
        /// S4HSIVDL.
        /// </summary>
        public const string S4HSIVDL = "S4HSIVDL";

        /// <summary>
        /// S4HSIVF.
        /// </summary>
        public const string S4HSIVF = "S4HSIVF";

        /// <summary>
        /// S4HSIVPO.
        /// </summary>
        public const string S4HSIVPO = "S4HSIVPO";

        /// <summary>
        /// S4HSIVI.
        /// </summary>
        public const string S4HSIVI = "S4HSIVI";

        /// <summary>
        /// S4HSIVIC.
        /// </summary>
        public const string S4HSIVIC = "S4HSIVIC";

        /// <summary>
        /// S4HSIQ1.
        /// </summary>
        public const string S4HSIQ1 = "S4HSIQ1";

        /// <summary>
        /// S4HSIQ2.
        /// </summary>
        public const string S4HSIQ2 = "S4HSIQ2";

        /// <summary>
        /// S4HSIQ3.
        /// </summary>
        public const string S4HSIQ3 = "S4HSIQ3";

        /// <summary>
        /// S4HSIQ4.
        /// </summary>
        public const string S4HSIQ4 = "S4HSIQ4";

        /// <summary>
        /// S4HSIQ5.
        /// </summary>
        public const string S4HSIQ5 = "S4HSIQ5";

        /// <summary>
        /// S4URAB.
        /// </summary>
        public const string S4URAB = "S4URAB";

        /// <summary>
        /// S4URCD.
        /// </summary>
        public const string S4URCD = "S4URCD";

        /// <summary>
        /// S4URAT.
        /// </summary>
        public const string S4URAT = "S4URAT";

        /// <summary>
        /// S4URDT.
        /// </summary>
        public const string S4URDT = "S4URDT";

        /// <summary>
        /// S4URRF.
        /// </summary>
        public const string S4URRF = "S4URRF";

        /// <summary>
        /// S4USER.
        /// </summary>
        public const string S4USER = "S4USER";

        /// <summary>
        /// S4UPMJ.
        /// </summary>
        public const string S4UPMJ = "S4UPMJ";

        /// <summary>
        /// S4UPMT.
        /// </summary>
        public const string S4UPMT = "S4UPMT";

        /// <summary>
        /// S4JOBN.
        /// </summary>
        public const string S4JOBN = "S4JOBN";

        /// <summary>
        /// S4PID.
        /// </summary>
        public const string S4PID = "S4PID";

        /// <summary>
        /// S4EQMAKE.
        /// </summary>
        public const string S4EQMAKE = "S4EQMAKE";

        /// <summary>
        /// S4EQMODEL.
        /// </summary>
        public const string S4EQMODEL = "S4EQMODEL";

        /// <summary>
        /// S4EQYEAR.
        /// </summary>
        public const string S4EQYEAR = "S4EQYEAR";

        /// <summary>
        /// S4HSIQ6.
        /// </summary>
        public const string S4HSIQ6 = "S4HSIQ6";

        /// <summary>
        /// S4HSIQ7.
        /// </summary>
        public const string S4HSIQ7 = "S4HSIQ7";

        /// <summary>
        /// S4HSIQ8.
        /// </summary>
        public const string S4HSIQ8 = "S4HSIQ8";

        /// <summary>
        /// S4HSIQ9.
        /// </summary>
        public const string S4HSIQ9 = "S4HSIQ9";

        /// <summary>
        /// S4HSIQ0.
        /// </summary>
        public const string S4HSIQ0 = "S4HSIQ0";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S4HSINO", "S4HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S4UKID", "S4UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("S4NUMB", "S4NUMB", JdeDataType.Numeric),
        new JdeField("S4DL01", "S4DL01", JdeDataType.String, 60),
        new JdeField("S4HSIDG", "S4HSIDG", JdeDataType.String, 2),
        new JdeField("S4HSIDD", "S4HSIDD", JdeDataType.String, 400),
        new JdeField("S4HSISED", "S4HSISED", JdeDataType.String, 4),
        new JdeField("S4HSIEQS", "S4HSIEQS", JdeDataType.String, 4),
        new JdeField("S4HSI3PE", "S4HSI3PE", JdeDataType.String, 2),
        new JdeField("S4HSI3PO", "S4HSI3PO", JdeDataType.String, 80),
        new JdeField("S4HSI3PC", "S4HSI3PC", JdeDataType.String, 2),
        new JdeField("S4HSIVM", "S4HSIVM", JdeDataType.String, 2),
        new JdeField("S4HSIVC", "S4HSIVC", JdeDataType.String, 4),
        new JdeField("S4HSIVV", "S4HSIVV", JdeDataType.String, 4),
        new JdeField("S4HSIVR", "S4HSIVR", JdeDataType.String, 4),
        new JdeField("S4HSIVP", "S4HSIVP", JdeDataType.String, 400),
        new JdeField("S4HSIVT", "S4HSIVT", JdeDataType.String, 400),
        new JdeField("S4HSIVN", "S4HSIVN", JdeDataType.String, 80),
        new JdeField("S4ADDS", "S4ADDS", JdeDataType.String, 6),
        new JdeField("S4LNUM", "S4LNUM", JdeDataType.String, 16),
        new JdeField("S4HSIVO", "S4HSIVO", JdeDataType.Numeric),
        new JdeField("S4HSIEO", "S4HSIEO", JdeDataType.Numeric),
        new JdeField("S4HSIVD", "S4HSIVD", JdeDataType.String, 80),
        new JdeField("S4HSIVDL", "S4HSIVDL", JdeDataType.String, 80),
        new JdeField("S4HSIVF", "S4HSIVF", JdeDataType.String, 2),
        new JdeField("S4HSIVPO", "S4HSIVPO", JdeDataType.String, 2),
        new JdeField("S4HSIVI", "S4HSIVI", JdeDataType.String, 80),
        new JdeField("S4HSIVIC", "S4HSIVIC", JdeDataType.String, 80),
        new JdeField("S4HSIQ1", "S4HSIQ1", JdeDataType.String, 6),
        new JdeField("S4HSIQ2", "S4HSIQ2", JdeDataType.String, 6),
        new JdeField("S4HSIQ3", "S4HSIQ3", JdeDataType.String, 6),
        new JdeField("S4HSIQ4", "S4HSIQ4", JdeDataType.String, 6),
        new JdeField("S4HSIQ5", "S4HSIQ5", JdeDataType.String, 6),
        new JdeField("S4URAB", "S4URAB", JdeDataType.Numeric),
        new JdeField("S4URCD", "S4URCD", JdeDataType.String, 4),
        new JdeField("S4URAT", "S4URAT", JdeDataType.Numeric),
        new JdeField("S4URDT", "S4URDT", JdeDataType.Numeric),
        new JdeField("S4URRF", "S4URRF", JdeDataType.String, 30),
        new JdeField("S4USER", "S4USER", JdeDataType.String, 20),
        new JdeField("S4UPMJ", "S4UPMJ", JdeDataType.Numeric),
        new JdeField("S4UPMT", "S4UPMT", JdeDataType.Numeric),
        new JdeField("S4JOBN", "S4JOBN", JdeDataType.String, 20),
        new JdeField("S4PID", "S4PID", JdeDataType.String, 20),
        new JdeField("S4EQMAKE", "S4EQMAKE", JdeDataType.String, 20),
        new JdeField("S4EQMODEL", "S4EQMODEL", JdeDataType.String, 20),
        new JdeField("S4EQYEAR", "S4EQYEAR", JdeDataType.String, 20),
        new JdeField("S4HSIQ6", "S4HSIQ6", JdeDataType.String, 20),
        new JdeField("S4HSIQ7", "S4HSIQ7", JdeDataType.String, 20),
        new JdeField("S4HSIQ8", "S4HSIQ8", JdeDataType.String, 20),
        new JdeField("S4HSIQ9", "S4HSIQ9", JdeDataType.String, 20),
        new JdeField("S4HSIQ0", "S4HSIQ0", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS03_0", "Primary Key on S4HSINO, S4UKID", new[] { "S4HSINO", "S4UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
