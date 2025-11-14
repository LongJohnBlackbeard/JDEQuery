using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J57 - .
/// </summary>
public class F09J57 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ORCO.
        /// </summary>
        public const string ORCO = "ORCO";

        /// <summary>
        /// ORJVNAME.
        /// </summary>
        public const string ORJVNAME = "ORJVNAME";

        /// <summary>
        /// ORMCUS.
        /// </summary>
        public const string ORMCUS = "ORMCUS";

        /// <summary>
        /// ORMCU.
        /// </summary>
        public const string ORMCU = "ORMCU";

        /// <summary>
        /// ORJVOVN.
        /// </summary>
        public const string ORJVOVN = "ORJVOVN";

        /// <summary>
        /// ORJVORAF.
        /// </summary>
        public const string ORJVORAF = "ORJVORAF";

        /// <summary>
        /// ORTORG.
        /// </summary>
        public const string ORTORG = "ORTORG";

        /// <summary>
        /// ORJVINUSR.
        /// </summary>
        public const string ORJVINUSR = "ORJVINUSR";

        /// <summary>
        /// ORENTJ.
        /// </summary>
        public const string ORENTJ = "ORENTJ";

        /// <summary>
        /// ORUSER.
        /// </summary>
        public const string ORUSER = "ORUSER";

        /// <summary>
        /// ORUPMJ.
        /// </summary>
        public const string ORUPMJ = "ORUPMJ";

        /// <summary>
        /// ORUPMT.
        /// </summary>
        public const string ORUPMT = "ORUPMT";

        /// <summary>
        /// ORPID.
        /// </summary>
        public const string ORPID = "ORPID";

        /// <summary>
        /// ORMKEY.
        /// </summary>
        public const string ORMKEY = "ORMKEY";

        /// <summary>
        /// ORJVPNU1.
        /// </summary>
        public const string ORJVPNU1 = "ORJVPNU1";

        /// <summary>
        /// ORJVPNU2.
        /// </summary>
        public const string ORJVPNU2 = "ORJVPNU2";

        /// <summary>
        /// ORJVPNU3.
        /// </summary>
        public const string ORJVPNU3 = "ORJVPNU3";

        /// <summary>
        /// ORJVPST1.
        /// </summary>
        public const string ORJVPST1 = "ORJVPST1";

        /// <summary>
        /// ORJVPST2.
        /// </summary>
        public const string ORJVPST2 = "ORJVPST2";

        /// <summary>
        /// ORJVPST3.
        /// </summary>
        public const string ORJVPST3 = "ORJVPST3";

        /// <summary>
        /// ORJVPCH1.
        /// </summary>
        public const string ORJVPCH1 = "ORJVPCH1";

        /// <summary>
        /// ORJVPCH2.
        /// </summary>
        public const string ORJVPCH2 = "ORJVPCH2";

        /// <summary>
        /// ORJVPCH3.
        /// </summary>
        public const string ORJVPCH3 = "ORJVPCH3";

        /// <summary>
        /// ORJVPDT1.
        /// </summary>
        public const string ORJVPDT1 = "ORJVPDT1";

        /// <summary>
        /// ORJVPDT2.
        /// </summary>
        public const string ORJVPDT2 = "ORJVPDT2";

        /// <summary>
        /// ORJVPDT3.
        /// </summary>
        public const string ORJVPDT3 = "ORJVPDT3";

        /// <summary>
        /// ORURSTRRA1.
        /// </summary>
        public const string ORURSTRRA1 = "ORURSTRRA1";

        /// <summary>
        /// ORURSTRRA2.
        /// </summary>
        public const string ORURSTRRA2 = "ORURSTRRA2";

        /// <summary>
        /// ORURSTRRA3.
        /// </summary>
        public const string ORURSTRRA3 = "ORURSTRRA3";

        /// <summary>
        /// ORURSTRRA4.
        /// </summary>
        public const string ORURSTRRA4 = "ORURSTRRA4";

        /// <summary>
        /// ORURSTRRA5.
        /// </summary>
        public const string ORURSTRRA5 = "ORURSTRRA5";

        /// <summary>
        /// ORURRFJRA1.
        /// </summary>
        public const string ORURRFJRA1 = "ORURRFJRA1";

        /// <summary>
        /// ORURRFJRA2.
        /// </summary>
        public const string ORURRFJRA2 = "ORURRFJRA2";

        /// <summary>
        /// ORURRFJRA3.
        /// </summary>
        public const string ORURRFJRA3 = "ORURRFJRA3";

        /// <summary>
        /// ORURRFJRA4.
        /// </summary>
        public const string ORURRFJRA4 = "ORURRFJRA4";

        /// <summary>
        /// ORURRFJRA5.
        /// </summary>
        public const string ORURRFJRA5 = "ORURRFJRA5";

        /// <summary>
        /// ORURNUMRA1.
        /// </summary>
        public const string ORURNUMRA1 = "ORURNUMRA1";

        /// <summary>
        /// ORURNUMRA2.
        /// </summary>
        public const string ORURNUMRA2 = "ORURNUMRA2";

        /// <summary>
        /// ORURNUMRA3.
        /// </summary>
        public const string ORURNUMRA3 = "ORURNUMRA3";

        /// <summary>
        /// ORURNUMRA4.
        /// </summary>
        public const string ORURNUMRA4 = "ORURNUMRA4";

        /// <summary>
        /// ORURNUMRA5.
        /// </summary>
        public const string ORURNUMRA5 = "ORURNUMRA5";

        /// <summary>
        /// ORURDTJRA1.
        /// </summary>
        public const string ORURDTJRA1 = "ORURDTJRA1";

        /// <summary>
        /// ORURDTJRA2.
        /// </summary>
        public const string ORURDTJRA2 = "ORURDTJRA2";

        /// <summary>
        /// ORURDTJRA3.
        /// </summary>
        public const string ORURDTJRA3 = "ORURDTJRA3";

        /// <summary>
        /// ORURDTJRA4.
        /// </summary>
        public const string ORURDTJRA4 = "ORURDTJRA4";

        /// <summary>
        /// ORURDTJRA5.
        /// </summary>
        public const string ORURDTJRA5 = "ORURDTJRA5";

        /// <summary>
        /// ORURCDJRA1.
        /// </summary>
        public const string ORURCDJRA1 = "ORURCDJRA1";

        /// <summary>
        /// ORURCDJRA2.
        /// </summary>
        public const string ORURCDJRA2 = "ORURCDJRA2";

        /// <summary>
        /// ORURCDJRA3.
        /// </summary>
        public const string ORURCDJRA3 = "ORURCDJRA3";

        /// <summary>
        /// ORURCDJRA4.
        /// </summary>
        public const string ORURCDJRA4 = "ORURCDJRA4";

        /// <summary>
        /// ORURCDJRA5.
        /// </summary>
        public const string ORURCDJRA5 = "ORURCDJRA5";

        /// <summary>
        /// ORURATJRA1.
        /// </summary>
        public const string ORURATJRA1 = "ORURATJRA1";

        /// <summary>
        /// ORURATJRA2.
        /// </summary>
        public const string ORURATJRA2 = "ORURATJRA2";

        /// <summary>
        /// ORURATJRA3.
        /// </summary>
        public const string ORURATJRA3 = "ORURATJRA3";

        /// <summary>
        /// ORURATJRA4.
        /// </summary>
        public const string ORURATJRA4 = "ORURATJRA4";

        /// <summary>
        /// ORURATJRA5.
        /// </summary>
        public const string ORURATJRA5 = "ORURATJRA5";
    }

    /// <inheritdoc />
    public override string TableName => "F09J57";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ORCO", "ORCO", JdeDataType.String, 10, true, true),
        new JdeField("ORJVNAME", "ORJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("ORMCUS", "ORMCUS", JdeDataType.String, 24, true, true),
        new JdeField("ORMCU", "ORMCU", JdeDataType.String, 24, true, true),
        new JdeField("ORJVOVN", "ORJVOVN", JdeDataType.String, 40, true, true),
        new JdeField("ORJVORAF", "ORJVORAF", JdeDataType.String, 2),
        new JdeField("ORTORG", "ORTORG", JdeDataType.String, 20),
        new JdeField("ORJVINUSR", "ORJVINUSR", JdeDataType.String, 20),
        new JdeField("ORENTJ", "ORENTJ", JdeDataType.Numeric),
        new JdeField("ORUSER", "ORUSER", JdeDataType.String, 20),
        new JdeField("ORUPMJ", "ORUPMJ", JdeDataType.Numeric),
        new JdeField("ORUPMT", "ORUPMT", JdeDataType.Numeric),
        new JdeField("ORPID", "ORPID", JdeDataType.String, 20),
        new JdeField("ORMKEY", "ORMKEY", JdeDataType.String, 30),
        new JdeField("ORJVPNU1", "ORJVPNU1", JdeDataType.Numeric),
        new JdeField("ORJVPNU2", "ORJVPNU2", JdeDataType.Numeric),
        new JdeField("ORJVPNU3", "ORJVPNU3", JdeDataType.Numeric),
        new JdeField("ORJVPST1", "ORJVPST1", JdeDataType.String, 160),
        new JdeField("ORJVPST2", "ORJVPST2", JdeDataType.String, 160),
        new JdeField("ORJVPST3", "ORJVPST3", JdeDataType.String, 160),
        new JdeField("ORJVPCH1", "ORJVPCH1", JdeDataType.String, 2),
        new JdeField("ORJVPCH2", "ORJVPCH2", JdeDataType.String, 2),
        new JdeField("ORJVPCH3", "ORJVPCH3", JdeDataType.String, 2),
        new JdeField("ORJVPDT1", "ORJVPDT1", JdeDataType.Numeric),
        new JdeField("ORJVPDT2", "ORJVPDT2", JdeDataType.Numeric),
        new JdeField("ORJVPDT3", "ORJVPDT3", JdeDataType.Numeric),
        new JdeField("ORURSTRRA1", "ORURSTRRA1", JdeDataType.String, 160),
        new JdeField("ORURSTRRA2", "ORURSTRRA2", JdeDataType.String, 160),
        new JdeField("ORURSTRRA3", "ORURSTRRA3", JdeDataType.String, 160),
        new JdeField("ORURSTRRA4", "ORURSTRRA4", JdeDataType.String, 160),
        new JdeField("ORURSTRRA5", "ORURSTRRA5", JdeDataType.String, 160),
        new JdeField("ORURRFJRA1", "ORURRFJRA1", JdeDataType.String, 30),
        new JdeField("ORURRFJRA2", "ORURRFJRA2", JdeDataType.String, 30),
        new JdeField("ORURRFJRA3", "ORURRFJRA3", JdeDataType.String, 30),
        new JdeField("ORURRFJRA4", "ORURRFJRA4", JdeDataType.String, 30),
        new JdeField("ORURRFJRA5", "ORURRFJRA5", JdeDataType.String, 30),
        new JdeField("ORURNUMRA1", "ORURNUMRA1", JdeDataType.Numeric),
        new JdeField("ORURNUMRA2", "ORURNUMRA2", JdeDataType.Numeric),
        new JdeField("ORURNUMRA3", "ORURNUMRA3", JdeDataType.Numeric),
        new JdeField("ORURNUMRA4", "ORURNUMRA4", JdeDataType.Numeric),
        new JdeField("ORURNUMRA5", "ORURNUMRA5", JdeDataType.Numeric),
        new JdeField("ORURDTJRA1", "ORURDTJRA1", JdeDataType.Numeric),
        new JdeField("ORURDTJRA2", "ORURDTJRA2", JdeDataType.Numeric),
        new JdeField("ORURDTJRA3", "ORURDTJRA3", JdeDataType.Numeric),
        new JdeField("ORURDTJRA4", "ORURDTJRA4", JdeDataType.Numeric),
        new JdeField("ORURDTJRA5", "ORURDTJRA5", JdeDataType.Numeric),
        new JdeField("ORURCDJRA1", "ORURCDJRA1", JdeDataType.String, 4),
        new JdeField("ORURCDJRA2", "ORURCDJRA2", JdeDataType.String, 4),
        new JdeField("ORURCDJRA3", "ORURCDJRA3", JdeDataType.String, 4),
        new JdeField("ORURCDJRA4", "ORURCDJRA4", JdeDataType.String, 4),
        new JdeField("ORURCDJRA5", "ORURCDJRA5", JdeDataType.String, 4),
        new JdeField("ORURATJRA1", "ORURATJRA1", JdeDataType.Numeric),
        new JdeField("ORURATJRA2", "ORURATJRA2", JdeDataType.Numeric),
        new JdeField("ORURATJRA3", "ORURATJRA3", JdeDataType.Numeric),
        new JdeField("ORURATJRA4", "ORURATJRA4", JdeDataType.Numeric),
        new JdeField("ORURATJRA5", "ORURATJRA5", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J57_0", "Primary Key on ORCO, ORJVNAME, ORMCUS, ORMCU, ORJVOVN", new[] { "ORCO", "ORJVNAME", "ORMCUS", "ORMCU", "ORJVOVN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J57_3", "Index on ORMCU", new[] { "ORMCU" })
    };
}
