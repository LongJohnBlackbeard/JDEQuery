using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40081 - .
/// </summary>
public class F40081 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EUEUCTR1.
        /// </summary>
        public const string EUEUCTR1 = "EUEUCTR1";

        /// <summary>
        /// EUEUCTR2.
        /// </summary>
        public const string EUEUCTR2 = "EUEUCTR2";

        /// <summary>
        /// EUEUTS.
        /// </summary>
        public const string EUEUTS = "EUEUTS";

        /// <summary>
        /// EUCO.
        /// </summary>
        public const string EUCO = "EUCO";

        /// <summary>
        /// EUAN8.
        /// </summary>
        public const string EUAN8 = "EUAN8";

        /// <summary>
        /// EUTXA1.
        /// </summary>
        public const string EUTXA1 = "EUTXA1";

        /// <summary>
        /// EUEUTC1.
        /// </summary>
        public const string EUEUTC1 = "EUEUTC1";

        /// <summary>
        /// EUEUTC2.
        /// </summary>
        public const string EUEUTC2 = "EUEUTC2";

        /// <summary>
        /// EUEUTN1.
        /// </summary>
        public const string EUEUTN1 = "EUEUTN1";

        /// <summary>
        /// EUEUTN2.
        /// </summary>
        public const string EUEUTN2 = "EUEUTN2";

        /// <summary>
        /// EUEUTS1.
        /// </summary>
        public const string EUEUTS1 = "EUEUTS1";

        /// <summary>
        /// EUEUTS2.
        /// </summary>
        public const string EUEUTS2 = "EUEUTS2";

        /// <summary>
        /// EUEUTS3.
        /// </summary>
        public const string EUEUTS3 = "EUEUTS3";

        /// <summary>
        /// EUEUTA1.
        /// </summary>
        public const string EUEUTA1 = "EUEUTA1";

        /// <summary>
        /// EUEUTA2.
        /// </summary>
        public const string EUEUTA2 = "EUEUTA2";

        /// <summary>
        /// EUEUTD1.
        /// </summary>
        public const string EUEUTD1 = "EUEUTD1";

        /// <summary>
        /// EUEUTD2.
        /// </summary>
        public const string EUEUTD2 = "EUEUTD2";

        /// <summary>
        /// EUURC1.
        /// </summary>
        public const string EUURC1 = "EUURC1";

        /// <summary>
        /// EUURAB.
        /// </summary>
        public const string EUURAB = "EUURAB";

        /// <summary>
        /// EUURRF.
        /// </summary>
        public const string EUURRF = "EUURRF";

        /// <summary>
        /// EUURAT.
        /// </summary>
        public const string EUURAT = "EUURAT";

        /// <summary>
        /// EUURDT.
        /// </summary>
        public const string EUURDT = "EUURDT";

        /// <summary>
        /// EUUSER.
        /// </summary>
        public const string EUUSER = "EUUSER";

        /// <summary>
        /// EUPID.
        /// </summary>
        public const string EUPID = "EUPID";

        /// <summary>
        /// EUUPMJ.
        /// </summary>
        public const string EUUPMJ = "EUUPMJ";

        /// <summary>
        /// EUUPMT.
        /// </summary>
        public const string EUUPMT = "EUUPMT";

        /// <summary>
        /// EUJOBN.
        /// </summary>
        public const string EUJOBN = "EUJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F40081";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EUEUCTR1", "EUEUCTR1", JdeDataType.String, 6, true, true),
        new JdeField("EUEUCTR2", "EUEUCTR2", JdeDataType.String, 6, true, true),
        new JdeField("EUEUTS", "EUEUTS", JdeDataType.String, 2, true, true),
        new JdeField("EUCO", "EUCO", JdeDataType.String, 10, true, true),
        new JdeField("EUAN8", "EUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EUTXA1", "EUTXA1", JdeDataType.String, 20),
        new JdeField("EUEUTC1", "EUEUTC1", JdeDataType.String, 2),
        new JdeField("EUEUTC2", "EUEUTC2", JdeDataType.String, 2),
        new JdeField("EUEUTN1", "EUEUTN1", JdeDataType.Numeric),
        new JdeField("EUEUTN2", "EUEUTN2", JdeDataType.Numeric),
        new JdeField("EUEUTS1", "EUEUTS1", JdeDataType.String, 6),
        new JdeField("EUEUTS2", "EUEUTS2", JdeDataType.String, 40),
        new JdeField("EUEUTS3", "EUEUTS3", JdeDataType.String, 60),
        new JdeField("EUEUTA1", "EUEUTA1", JdeDataType.Numeric),
        new JdeField("EUEUTA2", "EUEUTA2", JdeDataType.Numeric),
        new JdeField("EUEUTD1", "EUEUTD1", JdeDataType.Numeric),
        new JdeField("EUEUTD2", "EUEUTD2", JdeDataType.Numeric),
        new JdeField("EUURC1", "EUURC1", JdeDataType.String, 6),
        new JdeField("EUURAB", "EUURAB", JdeDataType.Numeric),
        new JdeField("EUURRF", "EUURRF", JdeDataType.String, 30),
        new JdeField("EUURAT", "EUURAT", JdeDataType.Numeric),
        new JdeField("EUURDT", "EUURDT", JdeDataType.Numeric),
        new JdeField("EUUSER", "EUUSER", JdeDataType.String, 20),
        new JdeField("EUPID", "EUPID", JdeDataType.String, 20),
        new JdeField("EUUPMJ", "EUUPMJ", JdeDataType.Numeric),
        new JdeField("EUUPMT", "EUUPMT", JdeDataType.Numeric),
        new JdeField("EUJOBN", "EUJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40081_0", "Primary Key on EUEUCTR1, EUEUCTR2, EUEUTS, EUCO, EUAN8", new[] { "EUEUCTR1", "EUEUCTR2", "EUEUTS", "EUCO", "EUAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40081_2", "Index on EUTXA1", new[] { "EUTXA1" })
    };
}
