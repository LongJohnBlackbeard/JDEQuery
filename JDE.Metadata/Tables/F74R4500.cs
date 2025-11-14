using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R4500 - .
/// </summary>
public class F74R4500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// POHDC.
        /// </summary>
        public const string POHDC = "POHDC";

        /// <summary>
        /// POKCO.
        /// </summary>
        public const string POKCO = "POKCO";

        /// <summary>
        /// PODCT.
        /// </summary>
        public const string PODCT = "PODCT";

        /// <summary>
        /// PODOC.
        /// </summary>
        public const string PODOC = "PODOC";

        /// <summary>
        /// POR74PTT.
        /// </summary>
        public const string POR74PTT = "POR74PTT";

        /// <summary>
        /// POR74DL01.
        /// </summary>
        public const string POR74DL01 = "POR74DL01";

        /// <summary>
        /// POVR01.
        /// </summary>
        public const string POVR01 = "POVR01";

        /// <summary>
        /// POTRDJ.
        /// </summary>
        public const string POTRDJ = "POTRDJ";

        /// <summary>
        /// POR74101P.
        /// </summary>
        public const string POR74101P = "POR74101P";

        /// <summary>
        /// POR74104P.
        /// </summary>
        public const string POR74104P = "POR74104P";

        /// <summary>
        /// POR74105P.
        /// </summary>
        public const string POR74105P = "POR74105P";

        /// <summary>
        /// POR74106P.
        /// </summary>
        public const string POR74106P = "POR74106P";

        /// <summary>
        /// POR74107P.
        /// </summary>
        public const string POR74107P = "POR74107P";

        /// <summary>
        /// PONUMY.
        /// </summary>
        public const string PONUMY = "PONUMY";

        /// <summary>
        /// PODSVJ.
        /// </summary>
        public const string PODSVJ = "PODSVJ";

        /// <summary>
        /// POR74107S.
        /// </summary>
        public const string POR74107S = "POR74107S";

        /// <summary>
        /// POR74108P.
        /// </summary>
        public const string POR74108P = "POR74108P";

        /// <summary>
        /// POR74109P.
        /// </summary>
        public const string POR74109P = "POR74109P";

        /// <summary>
        /// POR74110P.
        /// </summary>
        public const string POR74110P = "POR74110P";

        /// <summary>
        /// POURCD.
        /// </summary>
        public const string POURCD = "POURCD";

        /// <summary>
        /// POURDT.
        /// </summary>
        public const string POURDT = "POURDT";

        /// <summary>
        /// POURAT.
        /// </summary>
        public const string POURAT = "POURAT";

        /// <summary>
        /// POURAB.
        /// </summary>
        public const string POURAB = "POURAB";

        /// <summary>
        /// POURRF.
        /// </summary>
        public const string POURRF = "POURRF";

        /// <summary>
        /// POUSER.
        /// </summary>
        public const string POUSER = "POUSER";

        /// <summary>
        /// POPID.
        /// </summary>
        public const string POPID = "POPID";

        /// <summary>
        /// POJOBN.
        /// </summary>
        public const string POJOBN = "POJOBN";

        /// <summary>
        /// POUPMJ.
        /// </summary>
        public const string POUPMJ = "POUPMJ";

        /// <summary>
        /// POUPMT.
        /// </summary>
        public const string POUPMT = "POUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R4500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("POHDC", "POHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("POKCO", "POKCO", JdeDataType.String, 10, true, true),
        new JdeField("PODCT", "PODCT", JdeDataType.String, 4, true, true),
        new JdeField("PODOC", "PODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("POR74PTT", "POR74PTT", JdeDataType.String, 20),
        new JdeField("POR74DL01", "POR74DL01", JdeDataType.String, 500),
        new JdeField("POVR01", "POVR01", JdeDataType.String, 50),
        new JdeField("POTRDJ", "POTRDJ", JdeDataType.Numeric),
        new JdeField("POR74101P", "POR74101P", JdeDataType.String, 8),
        new JdeField("POR74104P", "POR74104P", JdeDataType.String, 20),
        new JdeField("POR74105P", "POR74105P", JdeDataType.String, 50),
        new JdeField("POR74106P", "POR74106P", JdeDataType.String, 10),
        new JdeField("POR74107P", "POR74107P", JdeDataType.String, 8),
        new JdeField("PONUMY", "PONUMY", JdeDataType.String, 8),
        new JdeField("PODSVJ", "PODSVJ", JdeDataType.Numeric),
        new JdeField("POR74107S", "POR74107S", JdeDataType.String, 24),
        new JdeField("POR74108P", "POR74108P", JdeDataType.String, 36),
        new JdeField("POR74109P", "POR74109P", JdeDataType.String, 20),
        new JdeField("POR74110P", "POR74110P", JdeDataType.String, 10),
        new JdeField("POURCD", "POURCD", JdeDataType.String, 4),
        new JdeField("POURDT", "POURDT", JdeDataType.Numeric),
        new JdeField("POURAT", "POURAT", JdeDataType.Numeric),
        new JdeField("POURAB", "POURAB", JdeDataType.Numeric),
        new JdeField("POURRF", "POURRF", JdeDataType.String, 30),
        new JdeField("POUSER", "POUSER", JdeDataType.String, 20),
        new JdeField("POPID", "POPID", JdeDataType.String, 20),
        new JdeField("POJOBN", "POJOBN", JdeDataType.String, 20),
        new JdeField("POUPMJ", "POUPMJ", JdeDataType.Numeric),
        new JdeField("POUPMT", "POUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R4500_0", "Primary Key on POHDC, POKCO, PODCT, PODOC", new[] { "POHDC", "POKCO", "PODCT", "PODOC" }, isUnique: true, isPrimaryKey: true)
    };
}
