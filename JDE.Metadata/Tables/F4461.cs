using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4461 - .
/// </summary>
public class F4461 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JNMCUS.
        /// </summary>
        public const string JNMCUS = "JNMCUS";

        /// <summary>
        /// JNOPTN.
        /// </summary>
        public const string JNOPTN = "JNOPTN";

        /// <summary>
        /// JNPL.
        /// </summary>
        public const string JNPL = "JNPL";

        /// <summary>
        /// JNELEV.
        /// </summary>
        public const string JNELEV = "JNELEV";

        /// <summary>
        /// JNPLNQ.
        /// </summary>
        public const string JNPLNQ = "JNPLNQ";

        /// <summary>
        /// JNGPPC.
        /// </summary>
        public const string JNGPPC = "JNGPPC";

        /// <summary>
        /// JNAMTO.
        /// </summary>
        public const string JNAMTO = "JNAMTO";

        /// <summary>
        /// JNSTRT.
        /// </summary>
        public const string JNSTRT = "JNSTRT";

        /// <summary>
        /// JNDPTP.
        /// </summary>
        public const string JNDPTP = "JNDPTP";

        /// <summary>
        /// JNCSPR.
        /// </summary>
        public const string JNCSPR = "JNCSPR";

        /// <summary>
        /// JNPSPR.
        /// </summary>
        public const string JNPSPR = "JNPSPR";

        /// <summary>
        /// JNSTRX.
        /// </summary>
        public const string JNSTRX = "JNSTRX";

        /// <summary>
        /// JNOP01.
        /// </summary>
        public const string JNOP01 = "JNOP01";

        /// <summary>
        /// JNOP02.
        /// </summary>
        public const string JNOP02 = "JNOP02";

        /// <summary>
        /// JNOP03.
        /// </summary>
        public const string JNOP03 = "JNOP03";

        /// <summary>
        /// JNOP04.
        /// </summary>
        public const string JNOP04 = "JNOP04";

        /// <summary>
        /// JNDL01.
        /// </summary>
        public const string JNDL01 = "JNDL01";

        /// <summary>
        /// JNDL02.
        /// </summary>
        public const string JNDL02 = "JNDL02";

        /// <summary>
        /// JNDL03.
        /// </summary>
        public const string JNDL03 = "JNDL03";

        /// <summary>
        /// JNDSC1.
        /// </summary>
        public const string JNDSC1 = "JNDSC1";

        /// <summary>
        /// JNDSC2.
        /// </summary>
        public const string JNDSC2 = "JNDSC2";

        /// <summary>
        /// JNDSC3.
        /// </summary>
        public const string JNDSC3 = "JNDSC3";

        /// <summary>
        /// JNUC01.
        /// </summary>
        public const string JNUC01 = "JNUC01";

        /// <summary>
        /// JNUC02.
        /// </summary>
        public const string JNUC02 = "JNUC02";

        /// <summary>
        /// JNUC03.
        /// </summary>
        public const string JNUC03 = "JNUC03";

        /// <summary>
        /// JNUSD1.
        /// </summary>
        public const string JNUSD1 = "JNUSD1";

        /// <summary>
        /// JNUSD2.
        /// </summary>
        public const string JNUSD2 = "JNUSD2";

        /// <summary>
        /// JNUSD3.
        /// </summary>
        public const string JNUSD3 = "JNUSD3";

        /// <summary>
        /// JNPID.
        /// </summary>
        public const string JNPID = "JNPID";

        /// <summary>
        /// JNUPMJ.
        /// </summary>
        public const string JNUPMJ = "JNUPMJ";

        /// <summary>
        /// JNEFFF.
        /// </summary>
        public const string JNEFFF = "JNEFFF";

        /// <summary>
        /// JNUSER.
        /// </summary>
        public const string JNUSER = "JNUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F4461";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JNMCUS", "JNMCUS", JdeDataType.String, 24, true, true),
        new JdeField("JNOPTN", "JNOPTN", JdeDataType.String, 16, true, true),
        new JdeField("JNPL", "JNPL", JdeDataType.String, 8, true, true),
        new JdeField("JNELEV", "JNELEV", JdeDataType.String, 6, true, true),
        new JdeField("JNPLNQ", "JNPLNQ", JdeDataType.String, 50),
        new JdeField("JNGPPC", "JNGPPC", JdeDataType.Numeric),
        new JdeField("JNAMTO", "JNAMTO", JdeDataType.Numeric),
        new JdeField("JNSTRT", "JNSTRT", JdeDataType.Numeric),
        new JdeField("JNDPTP", "JNDPTP", JdeDataType.Numeric),
        new JdeField("JNCSPR", "JNCSPR", JdeDataType.Numeric),
        new JdeField("JNPSPR", "JNPSPR", JdeDataType.Numeric),
        new JdeField("JNSTRX", "JNSTRX", JdeDataType.Numeric),
        new JdeField("JNOP01", "JNOP01", JdeDataType.String, 6),
        new JdeField("JNOP02", "JNOP02", JdeDataType.String, 6),
        new JdeField("JNOP03", "JNOP03", JdeDataType.String, 6),
        new JdeField("JNOP04", "JNOP04", JdeDataType.String, 6),
        new JdeField("JNDL01", "JNDL01", JdeDataType.String, 60),
        new JdeField("JNDL02", "JNDL02", JdeDataType.String, 60),
        new JdeField("JNDL03", "JNDL03", JdeDataType.String, 60),
        new JdeField("JNDSC1", "JNDSC1", JdeDataType.String, 60),
        new JdeField("JNDSC2", "JNDSC2", JdeDataType.String, 60),
        new JdeField("JNDSC3", "JNDSC3", JdeDataType.String, 60),
        new JdeField("JNUC01", "JNUC01", JdeDataType.String, 2),
        new JdeField("JNUC02", "JNUC02", JdeDataType.String, 2),
        new JdeField("JNUC03", "JNUC03", JdeDataType.String, 2),
        new JdeField("JNUSD1", "JNUSD1", JdeDataType.Numeric),
        new JdeField("JNUSD2", "JNUSD2", JdeDataType.Numeric),
        new JdeField("JNUSD3", "JNUSD3", JdeDataType.Numeric),
        new JdeField("JNPID", "JNPID", JdeDataType.String, 20),
        new JdeField("JNUPMJ", "JNUPMJ", JdeDataType.Numeric),
        new JdeField("JNEFFF", "JNEFFF", JdeDataType.Numeric),
        new JdeField("JNUSER", "JNUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4461_0", "Primary Key on JNOPTN, JNMCUS, JNPL, JNELEV", new[] { "JNOPTN", "JNMCUS", "JNPL", "JNELEV" }, isUnique: true, isPrimaryKey: true)
    };
}
