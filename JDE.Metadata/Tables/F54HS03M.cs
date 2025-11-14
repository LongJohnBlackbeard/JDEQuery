using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS03M - .
/// </summary>
public class F54HS03M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I4HSINO.
        /// </summary>
        public const string I4HSINO = "I4HSINO";

        /// <summary>
        /// I4UKID.
        /// </summary>
        public const string I4UKID = "I4UKID";

        /// <summary>
        /// I4HSIMN.
        /// </summary>
        public const string I4HSIMN = "I4HSIMN";

        /// <summary>
        /// I4HSIMT.
        /// </summary>
        public const string I4HSIMT = "I4HSIMT";

        /// <summary>
        /// I4MODDT.
        /// </summary>
        public const string I4MODDT = "I4MODDT";

        /// <summary>
        /// I4NUMB.
        /// </summary>
        public const string I4NUMB = "I4NUMB";

        /// <summary>
        /// I4DL01.
        /// </summary>
        public const string I4DL01 = "I4DL01";

        /// <summary>
        /// I4HSIDG.
        /// </summary>
        public const string I4HSIDG = "I4HSIDG";

        /// <summary>
        /// I4HSIDD.
        /// </summary>
        public const string I4HSIDD = "I4HSIDD";

        /// <summary>
        /// I4HSISED.
        /// </summary>
        public const string I4HSISED = "I4HSISED";

        /// <summary>
        /// I4HSIEQS.
        /// </summary>
        public const string I4HSIEQS = "I4HSIEQS";

        /// <summary>
        /// I4HSI3PE.
        /// </summary>
        public const string I4HSI3PE = "I4HSI3PE";

        /// <summary>
        /// I4HSI3PO.
        /// </summary>
        public const string I4HSI3PO = "I4HSI3PO";

        /// <summary>
        /// I4HSI3PC.
        /// </summary>
        public const string I4HSI3PC = "I4HSI3PC";

        /// <summary>
        /// I4HSIVM.
        /// </summary>
        public const string I4HSIVM = "I4HSIVM";

        /// <summary>
        /// I4HSIVC.
        /// </summary>
        public const string I4HSIVC = "I4HSIVC";

        /// <summary>
        /// I4HSIVV.
        /// </summary>
        public const string I4HSIVV = "I4HSIVV";

        /// <summary>
        /// I4HSIVR.
        /// </summary>
        public const string I4HSIVR = "I4HSIVR";

        /// <summary>
        /// I4HSIVP.
        /// </summary>
        public const string I4HSIVP = "I4HSIVP";

        /// <summary>
        /// I4HSIVT.
        /// </summary>
        public const string I4HSIVT = "I4HSIVT";

        /// <summary>
        /// I4HSIVN.
        /// </summary>
        public const string I4HSIVN = "I4HSIVN";

        /// <summary>
        /// I4ADDS.
        /// </summary>
        public const string I4ADDS = "I4ADDS";

        /// <summary>
        /// I4LNUM.
        /// </summary>
        public const string I4LNUM = "I4LNUM";

        /// <summary>
        /// I4HSIVO.
        /// </summary>
        public const string I4HSIVO = "I4HSIVO";

        /// <summary>
        /// I4HSIEO.
        /// </summary>
        public const string I4HSIEO = "I4HSIEO";

        /// <summary>
        /// I4HSIVD.
        /// </summary>
        public const string I4HSIVD = "I4HSIVD";

        /// <summary>
        /// I4HSIVDL.
        /// </summary>
        public const string I4HSIVDL = "I4HSIVDL";

        /// <summary>
        /// I4HSIVF.
        /// </summary>
        public const string I4HSIVF = "I4HSIVF";

        /// <summary>
        /// I4HSIVPO.
        /// </summary>
        public const string I4HSIVPO = "I4HSIVPO";

        /// <summary>
        /// I4HSIVI.
        /// </summary>
        public const string I4HSIVI = "I4HSIVI";

        /// <summary>
        /// I4HSIVIC.
        /// </summary>
        public const string I4HSIVIC = "I4HSIVIC";

        /// <summary>
        /// I4HSIQ1.
        /// </summary>
        public const string I4HSIQ1 = "I4HSIQ1";

        /// <summary>
        /// I4HSIQ2.
        /// </summary>
        public const string I4HSIQ2 = "I4HSIQ2";

        /// <summary>
        /// I4HSIQ3.
        /// </summary>
        public const string I4HSIQ3 = "I4HSIQ3";

        /// <summary>
        /// I4HSIQ4.
        /// </summary>
        public const string I4HSIQ4 = "I4HSIQ4";

        /// <summary>
        /// I4HSIQ5.
        /// </summary>
        public const string I4HSIQ5 = "I4HSIQ5";

        /// <summary>
        /// I4URAB.
        /// </summary>
        public const string I4URAB = "I4URAB";

        /// <summary>
        /// I4URCD.
        /// </summary>
        public const string I4URCD = "I4URCD";

        /// <summary>
        /// I4URAT.
        /// </summary>
        public const string I4URAT = "I4URAT";

        /// <summary>
        /// I4URDT.
        /// </summary>
        public const string I4URDT = "I4URDT";

        /// <summary>
        /// I4URRF.
        /// </summary>
        public const string I4URRF = "I4URRF";

        /// <summary>
        /// I4USER.
        /// </summary>
        public const string I4USER = "I4USER";

        /// <summary>
        /// I4UPMJ.
        /// </summary>
        public const string I4UPMJ = "I4UPMJ";

        /// <summary>
        /// I4UPMT.
        /// </summary>
        public const string I4UPMT = "I4UPMT";

        /// <summary>
        /// I4JOBN.
        /// </summary>
        public const string I4JOBN = "I4JOBN";

        /// <summary>
        /// I4PID.
        /// </summary>
        public const string I4PID = "I4PID";

        /// <summary>
        /// I4EQMAKE.
        /// </summary>
        public const string I4EQMAKE = "I4EQMAKE";

        /// <summary>
        /// I4EQMODEL.
        /// </summary>
        public const string I4EQMODEL = "I4EQMODEL";

        /// <summary>
        /// I4EQYEAR.
        /// </summary>
        public const string I4EQYEAR = "I4EQYEAR";

        /// <summary>
        /// I4HSIQ6.
        /// </summary>
        public const string I4HSIQ6 = "I4HSIQ6";

        /// <summary>
        /// I4HSIQ7.
        /// </summary>
        public const string I4HSIQ7 = "I4HSIQ7";

        /// <summary>
        /// I4HSIQ8.
        /// </summary>
        public const string I4HSIQ8 = "I4HSIQ8";

        /// <summary>
        /// I4HSIQ9.
        /// </summary>
        public const string I4HSIQ9 = "I4HSIQ9";

        /// <summary>
        /// I4HSIQ0.
        /// </summary>
        public const string I4HSIQ0 = "I4HSIQ0";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS03M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I4HSINO", "I4HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I4UKID", "I4UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I4HSIMN", "I4HSIMN", JdeDataType.Numeric, null, true, true),
        new JdeField("I4HSIMT", "I4HSIMT", JdeDataType.String, 2),
        new JdeField("I4MODDT", "I4MODDT", JdeDataType.Numeric),
        new JdeField("I4NUMB", "I4NUMB", JdeDataType.Numeric),
        new JdeField("I4DL01", "I4DL01", JdeDataType.String, 60),
        new JdeField("I4HSIDG", "I4HSIDG", JdeDataType.String, 2),
        new JdeField("I4HSIDD", "I4HSIDD", JdeDataType.String, 400),
        new JdeField("I4HSISED", "I4HSISED", JdeDataType.String, 4),
        new JdeField("I4HSIEQS", "I4HSIEQS", JdeDataType.String, 4),
        new JdeField("I4HSI3PE", "I4HSI3PE", JdeDataType.String, 2),
        new JdeField("I4HSI3PO", "I4HSI3PO", JdeDataType.String, 80),
        new JdeField("I4HSI3PC", "I4HSI3PC", JdeDataType.String, 2),
        new JdeField("I4HSIVM", "I4HSIVM", JdeDataType.String, 2),
        new JdeField("I4HSIVC", "I4HSIVC", JdeDataType.String, 4),
        new JdeField("I4HSIVV", "I4HSIVV", JdeDataType.String, 4),
        new JdeField("I4HSIVR", "I4HSIVR", JdeDataType.String, 4),
        new JdeField("I4HSIVP", "I4HSIVP", JdeDataType.String, 400),
        new JdeField("I4HSIVT", "I4HSIVT", JdeDataType.String, 400),
        new JdeField("I4HSIVN", "I4HSIVN", JdeDataType.String, 80),
        new JdeField("I4ADDS", "I4ADDS", JdeDataType.String, 6),
        new JdeField("I4LNUM", "I4LNUM", JdeDataType.String, 16),
        new JdeField("I4HSIVO", "I4HSIVO", JdeDataType.Numeric),
        new JdeField("I4HSIEO", "I4HSIEO", JdeDataType.Numeric),
        new JdeField("I4HSIVD", "I4HSIVD", JdeDataType.String, 80),
        new JdeField("I4HSIVDL", "I4HSIVDL", JdeDataType.String, 80),
        new JdeField("I4HSIVF", "I4HSIVF", JdeDataType.String, 2),
        new JdeField("I4HSIVPO", "I4HSIVPO", JdeDataType.String, 2),
        new JdeField("I4HSIVI", "I4HSIVI", JdeDataType.String, 80),
        new JdeField("I4HSIVIC", "I4HSIVIC", JdeDataType.String, 80),
        new JdeField("I4HSIQ1", "I4HSIQ1", JdeDataType.String, 6),
        new JdeField("I4HSIQ2", "I4HSIQ2", JdeDataType.String, 6),
        new JdeField("I4HSIQ3", "I4HSIQ3", JdeDataType.String, 6),
        new JdeField("I4HSIQ4", "I4HSIQ4", JdeDataType.String, 6),
        new JdeField("I4HSIQ5", "I4HSIQ5", JdeDataType.String, 6),
        new JdeField("I4URAB", "I4URAB", JdeDataType.Numeric),
        new JdeField("I4URCD", "I4URCD", JdeDataType.String, 4),
        new JdeField("I4URAT", "I4URAT", JdeDataType.Numeric),
        new JdeField("I4URDT", "I4URDT", JdeDataType.Numeric),
        new JdeField("I4URRF", "I4URRF", JdeDataType.String, 30),
        new JdeField("I4USER", "I4USER", JdeDataType.String, 20),
        new JdeField("I4UPMJ", "I4UPMJ", JdeDataType.Numeric),
        new JdeField("I4UPMT", "I4UPMT", JdeDataType.Numeric),
        new JdeField("I4JOBN", "I4JOBN", JdeDataType.String, 20),
        new JdeField("I4PID", "I4PID", JdeDataType.String, 20),
        new JdeField("I4EQMAKE", "I4EQMAKE", JdeDataType.String, 20),
        new JdeField("I4EQMODEL", "I4EQMODEL", JdeDataType.String, 20),
        new JdeField("I4EQYEAR", "I4EQYEAR", JdeDataType.String, 20),
        new JdeField("I4HSIQ6", "I4HSIQ6", JdeDataType.String, 20),
        new JdeField("I4HSIQ7", "I4HSIQ7", JdeDataType.String, 20),
        new JdeField("I4HSIQ8", "I4HSIQ8", JdeDataType.String, 20),
        new JdeField("I4HSIQ9", "I4HSIQ9", JdeDataType.String, 20),
        new JdeField("I4HSIQ0", "I4HSIQ0", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS03M_0", "Primary Key on I4HSINO, I4UKID, I4HSIMN", new[] { "I4HSINO", "I4UKID", "I4HSIMN" }, isUnique: true, isPrimaryKey: true)
    };
}
