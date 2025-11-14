using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F82108 - .
/// </summary>
public class F82108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A3QRYG.
        /// </summary>
        public const string A3QRYG = "A3QRYG";

        /// <summary>
        /// A3QRYN.
        /// </summary>
        public const string A3QRYN = "A3QRYN";

        /// <summary>
        /// A3QTOT.
        /// </summary>
        public const string A3QTOT = "A3QTOT";

        /// <summary>
        /// A3FFD.
        /// </summary>
        public const string A3FFD = "A3FFD";

        /// <summary>
        /// A3FFDI.
        /// </summary>
        public const string A3FFDI = "A3FFDI";

        /// <summary>
        /// A3DSCR.
        /// </summary>
        public const string A3DSCR = "A3DSCR";

        /// <summary>
        /// A3SF01.
        /// </summary>
        public const string A3SF01 = "A3SF01";

        /// <summary>
        /// A3SF02.
        /// </summary>
        public const string A3SF02 = "A3SF02";

        /// <summary>
        /// A3SF03.
        /// </summary>
        public const string A3SF03 = "A3SF03";

        /// <summary>
        /// A3SF04.
        /// </summary>
        public const string A3SF04 = "A3SF04";

        /// <summary>
        /// A3SF05.
        /// </summary>
        public const string A3SF05 = "A3SF05";

        /// <summary>
        /// A3SF06.
        /// </summary>
        public const string A3SF06 = "A3SF06";

        /// <summary>
        /// A3SF07.
        /// </summary>
        public const string A3SF07 = "A3SF07";

        /// <summary>
        /// A3SF08.
        /// </summary>
        public const string A3SF08 = "A3SF08";

        /// <summary>
        /// A3SF09.
        /// </summary>
        public const string A3SF09 = "A3SF09";

        /// <summary>
        /// A3SF10.
        /// </summary>
        public const string A3SF10 = "A3SF10";

        /// <summary>
        /// A3ZA01.
        /// </summary>
        public const string A3ZA01 = "A3ZA01";

        /// <summary>
        /// A3ZA02.
        /// </summary>
        public const string A3ZA02 = "A3ZA02";

        /// <summary>
        /// A3ZA03.
        /// </summary>
        public const string A3ZA03 = "A3ZA03";

        /// <summary>
        /// A3ZA04.
        /// </summary>
        public const string A3ZA04 = "A3ZA04";

        /// <summary>
        /// A3ZA05.
        /// </summary>
        public const string A3ZA05 = "A3ZA05";

        /// <summary>
        /// A3ZA06.
        /// </summary>
        public const string A3ZA06 = "A3ZA06";

        /// <summary>
        /// A3ZA07.
        /// </summary>
        public const string A3ZA07 = "A3ZA07";

        /// <summary>
        /// A3ZA08.
        /// </summary>
        public const string A3ZA08 = "A3ZA08";

        /// <summary>
        /// A3ZA09.
        /// </summary>
        public const string A3ZA09 = "A3ZA09";

        /// <summary>
        /// A3ZA10.
        /// </summary>
        public const string A3ZA10 = "A3ZA10";

        /// <summary>
        /// A3ZB01.
        /// </summary>
        public const string A3ZB01 = "A3ZB01";

        /// <summary>
        /// A3ZB02.
        /// </summary>
        public const string A3ZB02 = "A3ZB02";

        /// <summary>
        /// A3ZB03.
        /// </summary>
        public const string A3ZB03 = "A3ZB03";

        /// <summary>
        /// A3ZB04.
        /// </summary>
        public const string A3ZB04 = "A3ZB04";

        /// <summary>
        /// A3ZB05.
        /// </summary>
        public const string A3ZB05 = "A3ZB05";

        /// <summary>
        /// A3ZB06.
        /// </summary>
        public const string A3ZB06 = "A3ZB06";

        /// <summary>
        /// A3ZB07.
        /// </summary>
        public const string A3ZB07 = "A3ZB07";

        /// <summary>
        /// A3ZB08.
        /// </summary>
        public const string A3ZB08 = "A3ZB08";

        /// <summary>
        /// A3ZB09.
        /// </summary>
        public const string A3ZB09 = "A3ZB09";

        /// <summary>
        /// A3ZB10.
        /// </summary>
        public const string A3ZB10 = "A3ZB10";

        /// <summary>
        /// A3ZC01.
        /// </summary>
        public const string A3ZC01 = "A3ZC01";

        /// <summary>
        /// A3ZC02.
        /// </summary>
        public const string A3ZC02 = "A3ZC02";

        /// <summary>
        /// A3ZC03.
        /// </summary>
        public const string A3ZC03 = "A3ZC03";

        /// <summary>
        /// A3ZC04.
        /// </summary>
        public const string A3ZC04 = "A3ZC04";

        /// <summary>
        /// A3ZC05.
        /// </summary>
        public const string A3ZC05 = "A3ZC05";

        /// <summary>
        /// A3ZC06.
        /// </summary>
        public const string A3ZC06 = "A3ZC06";

        /// <summary>
        /// A3ZC07.
        /// </summary>
        public const string A3ZC07 = "A3ZC07";

        /// <summary>
        /// A3ZC08.
        /// </summary>
        public const string A3ZC08 = "A3ZC08";

        /// <summary>
        /// A3ZC09.
        /// </summary>
        public const string A3ZC09 = "A3ZC09";

        /// <summary>
        /// A3ZC10.
        /// </summary>
        public const string A3ZC10 = "A3ZC10";
    }

    /// <inheritdoc />
    public override string TableName => "F82108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A3QRYG", "A3QRYG", JdeDataType.String, 20, true, true),
        new JdeField("A3QRYN", "A3QRYN", JdeDataType.String, 20, true, true),
        new JdeField("A3QTOT", "A3QTOT", JdeDataType.Numeric, null, true, true),
        new JdeField("A3FFD", "A3FFD", JdeDataType.String, 20, true, true),
        new JdeField("A3FFDI", "A3FFDI", JdeDataType.Numeric, null, true, true),
        new JdeField("A3DSCR", "A3DSCR", JdeDataType.String, 80),
        new JdeField("A3SF01", "A3SF01", JdeDataType.String, 2),
        new JdeField("A3SF02", "A3SF02", JdeDataType.String, 2),
        new JdeField("A3SF03", "A3SF03", JdeDataType.String, 2),
        new JdeField("A3SF04", "A3SF04", JdeDataType.String, 2),
        new JdeField("A3SF05", "A3SF05", JdeDataType.String, 2),
        new JdeField("A3SF06", "A3SF06", JdeDataType.String, 2),
        new JdeField("A3SF07", "A3SF07", JdeDataType.String, 2),
        new JdeField("A3SF08", "A3SF08", JdeDataType.String, 2),
        new JdeField("A3SF09", "A3SF09", JdeDataType.String, 2),
        new JdeField("A3SF10", "A3SF10", JdeDataType.String, 2),
        new JdeField("A3ZA01", "A3ZA01", JdeDataType.Numeric),
        new JdeField("A3ZA02", "A3ZA02", JdeDataType.Numeric),
        new JdeField("A3ZA03", "A3ZA03", JdeDataType.Numeric),
        new JdeField("A3ZA04", "A3ZA04", JdeDataType.Numeric),
        new JdeField("A3ZA05", "A3ZA05", JdeDataType.Numeric),
        new JdeField("A3ZA06", "A3ZA06", JdeDataType.Numeric),
        new JdeField("A3ZA07", "A3ZA07", JdeDataType.Numeric),
        new JdeField("A3ZA08", "A3ZA08", JdeDataType.Numeric),
        new JdeField("A3ZA09", "A3ZA09", JdeDataType.Numeric),
        new JdeField("A3ZA10", "A3ZA10", JdeDataType.Numeric),
        new JdeField("A3ZB01", "A3ZB01", JdeDataType.Numeric),
        new JdeField("A3ZB02", "A3ZB02", JdeDataType.Numeric),
        new JdeField("A3ZB03", "A3ZB03", JdeDataType.Numeric),
        new JdeField("A3ZB04", "A3ZB04", JdeDataType.Numeric),
        new JdeField("A3ZB05", "A3ZB05", JdeDataType.Numeric),
        new JdeField("A3ZB06", "A3ZB06", JdeDataType.Numeric),
        new JdeField("A3ZB07", "A3ZB07", JdeDataType.Numeric),
        new JdeField("A3ZB08", "A3ZB08", JdeDataType.Numeric),
        new JdeField("A3ZB09", "A3ZB09", JdeDataType.Numeric),
        new JdeField("A3ZB10", "A3ZB10", JdeDataType.Numeric),
        new JdeField("A3ZC01", "A3ZC01", JdeDataType.Numeric),
        new JdeField("A3ZC02", "A3ZC02", JdeDataType.Numeric),
        new JdeField("A3ZC03", "A3ZC03", JdeDataType.Numeric),
        new JdeField("A3ZC04", "A3ZC04", JdeDataType.Numeric),
        new JdeField("A3ZC05", "A3ZC05", JdeDataType.Numeric),
        new JdeField("A3ZC06", "A3ZC06", JdeDataType.Numeric),
        new JdeField("A3ZC07", "A3ZC07", JdeDataType.Numeric),
        new JdeField("A3ZC08", "A3ZC08", JdeDataType.Numeric),
        new JdeField("A3ZC09", "A3ZC09", JdeDataType.Numeric),
        new JdeField("A3ZC10", "A3ZC10", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F82108_0", "Primary Key on A3QRYG, A3QRYN, A3QTOT, A3FFD, A3FFDI", new[] { "A3QRYG", "A3QRYN", "A3QTOT", "A3FFD", "A3FFDI" }, isUnique: true, isPrimaryKey: true)
    };
}
