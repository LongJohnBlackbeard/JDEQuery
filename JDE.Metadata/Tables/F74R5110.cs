using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R5110 - .
/// </summary>
public class F74R5110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFCO.
        /// </summary>
        public const string TFCO = "TFCO";

        /// <summary>
        /// TFNUMB.
        /// </summary>
        public const string TFNUMB = "TFNUMB";

        /// <summary>
        /// TFR74MAND.
        /// </summary>
        public const string TFR74MAND = "TFR74MAND";

        /// <summary>
        /// TFR74MODD.
        /// </summary>
        public const string TFR74MODD = "TFR74MODD";

        /// <summary>
        /// TFR74PLNA.
        /// </summary>
        public const string TFR74PLNA = "TFR74PLNA";

        /// <summary>
        /// TFR74PLNU.
        /// </summary>
        public const string TFR74PLNU = "TFR74PLNU";

        /// <summary>
        /// TFR74PLDA.
        /// </summary>
        public const string TFR74PLDA = "TFR74PLDA";

        /// <summary>
        /// TFR74ACPE.
        /// </summary>
        public const string TFR74ACPE = "TFR74ACPE";

        /// <summary>
        /// TFAA.
        /// </summary>
        public const string TFAA = "TFAA";

        /// <summary>
        /// TFR74NBV.
        /// </summary>
        public const string TFR74NBV = "TFR74NBV";

        /// <summary>
        /// TFR74MEM.
        /// </summary>
        public const string TFR74MEM = "TFR74MEM";

        /// <summary>
        /// TFR74SHAP.
        /// </summary>
        public const string TFR74SHAP = "TFR74SHAP";

        /// <summary>
        /// TFR74JEW.
        /// </summary>
        public const string TFR74JEW = "TFR74JEW";

        /// <summary>
        /// TFR74INU.
        /// </summary>
        public const string TFR74INU = "TFR74INU";

        /// <summary>
        /// TFUOM.
        /// </summary>
        public const string TFUOM = "TFUOM";

        /// <summary>
        /// TFQT2.
        /// </summary>
        public const string TFQT2 = "TFQT2";

        /// <summary>
        /// TFAWGT.
        /// </summary>
        public const string TFAWGT = "TFAWGT";

        /// <summary>
        /// TFR74CHAR.
        /// </summary>
        public const string TFR74CHAR = "TFR74CHAR";

        /// <summary>
        /// TFR74INU0.
        /// </summary>
        public const string TFR74INU0 = "TFR74INU0";

        /// <summary>
        /// TFR74INU1.
        /// </summary>
        public const string TFR74INU1 = "TFR74INU1";

        /// <summary>
        /// TFR74INU2.
        /// </summary>
        public const string TFR74INU2 = "TFR74INU2";

        /// <summary>
        /// TFR74INU3.
        /// </summary>
        public const string TFR74INU3 = "TFR74INU3";

        /// <summary>
        /// TFR74INU4.
        /// </summary>
        public const string TFR74INU4 = "TFR74INU4";

        /// <summary>
        /// TFRMK.
        /// </summary>
        public const string TFRMK = "TFRMK";

        /// <summary>
        /// TFURAB.
        /// </summary>
        public const string TFURAB = "TFURAB";

        /// <summary>
        /// TFURAT.
        /// </summary>
        public const string TFURAT = "TFURAT";

        /// <summary>
        /// TFURRF.
        /// </summary>
        public const string TFURRF = "TFURRF";

        /// <summary>
        /// TFUSER.
        /// </summary>
        public const string TFUSER = "TFUSER";

        /// <summary>
        /// TFPID.
        /// </summary>
        public const string TFPID = "TFPID";

        /// <summary>
        /// TFJOBN.
        /// </summary>
        public const string TFJOBN = "TFJOBN";

        /// <summary>
        /// TFUPMJ.
        /// </summary>
        public const string TFUPMJ = "TFUPMJ";

        /// <summary>
        /// TFUPMT.
        /// </summary>
        public const string TFUPMT = "TFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R5110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFCO", "TFCO", JdeDataType.String, 10, true, true),
        new JdeField("TFNUMB", "TFNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("TFR74MAND", "TFR74MAND", JdeDataType.Numeric),
        new JdeField("TFR74MODD", "TFR74MODD", JdeDataType.Numeric),
        new JdeField("TFR74PLNA", "TFR74PLNA", JdeDataType.String, 60),
        new JdeField("TFR74PLNU", "TFR74PLNU", JdeDataType.String, 30),
        new JdeField("TFR74PLDA", "TFR74PLDA", JdeDataType.Numeric),
        new JdeField("TFR74ACPE", "TFR74ACPE", JdeDataType.Numeric),
        new JdeField("TFAA", "TFAA", JdeDataType.Numeric),
        new JdeField("TFR74NBV", "TFR74NBV", JdeDataType.Numeric),
        new JdeField("TFR74MEM", "TFR74MEM", JdeDataType.String, 60),
        new JdeField("TFR74SHAP", "TFR74SHAP", JdeDataType.Numeric),
        new JdeField("TFR74JEW", "TFR74JEW", JdeDataType.String, 60),
        new JdeField("TFR74INU", "TFR74INU", JdeDataType.Numeric),
        new JdeField("TFUOM", "TFUOM", JdeDataType.String, 4),
        new JdeField("TFQT2", "TFQT2", JdeDataType.Numeric),
        new JdeField("TFAWGT", "TFAWGT", JdeDataType.Numeric),
        new JdeField("TFR74CHAR", "TFR74CHAR", JdeDataType.String, 60),
        new JdeField("TFR74INU0", "TFR74INU0", JdeDataType.Numeric),
        new JdeField("TFR74INU1", "TFR74INU1", JdeDataType.Numeric),
        new JdeField("TFR74INU2", "TFR74INU2", JdeDataType.Numeric),
        new JdeField("TFR74INU3", "TFR74INU3", JdeDataType.Numeric),
        new JdeField("TFR74INU4", "TFR74INU4", JdeDataType.Numeric),
        new JdeField("TFRMK", "TFRMK", JdeDataType.String, 60),
        new JdeField("TFURAB", "TFURAB", JdeDataType.Numeric),
        new JdeField("TFURAT", "TFURAT", JdeDataType.Numeric),
        new JdeField("TFURRF", "TFURRF", JdeDataType.String, 30),
        new JdeField("TFUSER", "TFUSER", JdeDataType.String, 20),
        new JdeField("TFPID", "TFPID", JdeDataType.String, 20),
        new JdeField("TFJOBN", "TFJOBN", JdeDataType.String, 20),
        new JdeField("TFUPMJ", "TFUPMJ", JdeDataType.Numeric),
        new JdeField("TFUPMT", "TFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R5110_0", "Primary Key on TFCO, TFNUMB", new[] { "TFCO", "TFNUMB" }, isUnique: true, isPrimaryKey: true)
    };
}
